using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_LeHuuPhu
{
    class Cls_Phu
    {
        private string PersonInput = "";
        private string Result = "0";
        private string _inputString = "";
        private string _MemoryDone = "";
        public void SetIputString(String s)
        {
            _inputString = s;
        }

        public String GetInputString()
        {
            return _inputString;
        }

        public void SetResult(String Input)
        {
            Result = Input;
        }

        public String GetResult()
        {
            return Result;
        }

        public void SetPersonInput(String Input)
        {
            PersonInput = Input;
        }

        public void AddPersonInput(String Input)
        {
            //Console.WriteLine(Input);
            //validation input
            _MemoryDone = "";
            SetResult("0");
            

            if (PersonInput.Length == 0)
            {
                // error input
                if (Input.Equals("+") || Input.Equals("*") || Input.Equals("/") || Input.Equals("%"))
                    Input = "";
                if (Input.Equals("."))
                    Input = "0.";
            }
            else
            {
                String tmp = PersonInput.Substring(PersonInput.Length - 1, 1);
                if ((tmp.Equals("*") || tmp.Equals("/") || tmp.Equals("+") || tmp.Equals("-"))
                    && (Input.Equals("*") || Input.Equals("/") || Input.Equals("+") || Input.Equals("-")))
                {
                    PersonInput = PersonInput.Substring(0, PersonInput.Length - 1);
                }
                if (Input.Equals("."))
                {
                    for(int i = PersonInput.Length - 1; i>=0; i--)
                    {
                        if(PersonInput[i].ToString().Equals("+") || PersonInput[i].ToString().Equals("-") || PersonInput[i].ToString().Equals("*") || PersonInput[i].ToString().Equals("/") || PersonInput[i].ToString().Equals("%"))
                        {
                            break;
                        }
                        if (PersonInput[i].ToString().Equals("."))
                        {
                            Input = "";
                        }
                    }
                }
            }
            Input = CheckInputPercentAndCommaAndDivZero(PersonInput, Input);
            PersonInput += Input;
            PersonInput = ReplaceInput(PersonInput);
        }

        public String GetPersonInput()
        {
            return PersonInput;
        }

        public void EvenButonAcOnClick()
        {
            Result = "0";
            PersonInput = "";
            _MemoryDone = "";
        }

        // kiểm tra độ ưu tiên của các toán tử
        int CheckPrioritized(string x)
        {
            if (x == "*" || x == "/" || x == "%")
                return 2;
            else if (x == "+" || x == "-")
                return 1;
            return 0;
        }

        // kiểm tra là toán hạng(0,1,2,3,4,5,6,7,8,9) hay toán tử(+-*/)
        int OperatorOrOperand(string x)
        {
            if (x == "*" || x == "/" || x == "%" || x == "+" || x == "-")
                return 0; // toan tu
            else
                return 1; // toan hang
        }
       
        public String ReplaceInput(String s)
        {
            if (s.Length == 1)
                if (s.EndsWith("+") || s.EndsWith("*") || s.EndsWith("/") || s.EndsWith("%"))
                    s = "";
            s = s.Replace("+.", "+0.");
            s = s.Replace("-.", "-0.");
            s = s.Replace("*.", "*0.");
            s = s.Replace("/.", "/0.");
            s = s.Replace(".+", ".0+");
            s = s.Replace(".-", ".0-");
            s = s.Replace(".*", ".0*");
            s = s.Replace("./", ".0/");
            string tmp = "";
            try
            { 
                for(int i=0; i<s.Length; i++)
                {
                    if (s[i].ToString().Equals("%") && OperatorOrOperand(s[i + 1].ToString()) == 1)
                        tmp += "%*";
                    else
                        tmp += s[i];
                }
                return tmp;
            }catch(Exception e)
            {
                return s;
            }
        }
       
        public String SwapOperator(String s)
        {
            String result = "";
            int index = -1;
            int check = -1; // check = 0 => +-,...
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i].ToString().Equals("+") || s[i].ToString().Equals("%") || s[i].ToString().Equals("-") || s[i].ToString().Equals("*") || s[i].ToString().Equals("/"))
                {
                    index = i;
                    if (OperatorOrOperand(s[i].ToString()) == 0)
                    {
                        try
                        {
                            if (OperatorOrOperand(s[i - 1].ToString()) == 0)
                                check = 0;
                            break;
                        }
                        catch (Exception e)
                        {
                            break;
                        }
                    }
                }
            }
            for (int i = 0; i < s.Length ; i++)
            {
                String tmp = s[i].ToString();
                if(i == index)
                {
                    if (s[i].ToString().Equals("+"))
                    {
                        if(check == 0)
                            tmp = "-";
                        else
                            tmp = "+-";
                    }
                    if (s[i].ToString().Equals("-"))
                    {
                        if (check == 0)
                            tmp = "";
                        else
                            tmp = "--";
                        if(index == 0)
                            tmp = "";
                    }
                    if (s[i].ToString().Equals("*"))
                    {
                        try
                        {
                            if ((s[i + 1].ToString().Equals("-")))
                                tmp = "*";
                            else
                                tmp = "*-";
                        }catch(Exception e)
                        {
                            tmp = "*";
                        }
                    }
                    if (s[i].ToString().Equals("/"))
                    {
                        try
                        {
                            if ((s[i + 1].ToString().Equals("-")))
                                tmp = "/";
                            else
                                tmp = "/-";
                        }catch(Exception e)
                        {
                            tmp = "/";
                        }
                    }
                    if (s[i].ToString().Equals("%"))
                    {
                        try
                        {
                            if ((s[i + 1].ToString().Equals("-")))
                                tmp = "%";
                            else
                                tmp = "%-";
                        }catch(Exception E)
                        {
                            tmp = "%";
                        }
                        
                    }
                }
                result += tmp;
            }
            if (index == -1)
                return "-" + result;
            if (result[0].ToString().Equals("+"))
                return result.Substring(1);
            return result;
        }

        public String InfixToPostfix(String input)
        {
            if (input[0].ToString().Equals("+"))
                input = input.Substring(1);
            if (input[input.Length-1].ToString().Equals("+") || input[input.Length - 1].ToString().Equals("-") || input[input.Length - 1].ToString().Equals("*") || input[input.Length - 1].ToString().Equals("/"))
                input = input.Substring(0, input.Length - 1);
            if (input[input.Length - 1].ToString().Equals("%"))
                input = input.Substring(0, input.Length - 1)+"/100";
            String p = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString().Equals("%"))
                    p += "/100";
                else
                    p += input[i];
            }
            input = p;
            SetIputString(input);
            input = input.Replace(",", ".");
            input = input.Replace("--", "+");
            input = input.Replace("+", " + ");
            input = input.Replace("-", " - ");
            input = input.Replace("*", " * ");
            input = input.Replace("/", " / ");
            input = input.Replace(" +  - ", " + -");
            input = input.Replace(" *  - ", " * -");
            input = input.Replace(" /  - ", " / -");
            input = input.Replace(" -  + ", " - ");
            input = input.Replace("--", " - -");
            input = input.Replace(" *  + ", " * ");
            input = input.Replace(" /  + ", " / ");
            if (input[0].ToString().Equals(" ") && input[1].ToString().Equals("-"))
            {
                String tmp = "";
                for(int i = 0; i<input.Length; i++)
                {
                    if (i < 2)
                    {
                        continue;
                    }
                    else
                    {
                        if (i == 2)
                        {
                            tmp += "-";
                        }
                        else
                        {
                            tmp += input[i];
                        }
                    }
                }
                input = tmp;
            }

            IEnumerable<string> str = input.Split(' ');
            Stack<string> stack = new Stack<string>();
            StringBuilder postfix = new StringBuilder();

            foreach (string s in str)
            {
                if (OperatorOrOperand(s) == 1) // Operand toan tu
                    postfix.Append(s).Append(" ");
                else// IsOperator(s)
                {
                    while (stack.Count > 0 && CheckPrioritized(s) <= CheckPrioritized(stack.Peek()))
                        postfix.Append(stack.Pop()).Append(" ");
                    stack.Push(s);
                }
            }
            while (stack.Count > 0)
            {
                postfix.Append(stack.Pop()).Append(" ");
            }
            //Console.WriteLine(postfix.ToString());
            return postfix.ToString();
        }

        public String RuningProcess(String input)
        {
            try
            {
                IEnumerable<string> str = input.Split(' ');
                Stack<string> stack = new Stack<string>();
                StringBuilder result = new StringBuilder();
                foreach (string s in str)
                {
                    if (OperatorOrOperand(s) == 1) // Operand toan tu
                        stack.Push(s);
                    else// IsOperator(s)
                    {
                        double ok = 0;
                        double number1 = double.Parse(stack.Pop());
                        double number2 = double.Parse(stack.Pop());
                        if (s.Equals("+"))
                        {
                            ok = number2 + number1;
                        }
                        if (s.Equals("-"))
                        {
                            ok = number2 - number1;
                        }
                        if (s.Equals("*"))
                        {
                            ok = number2 * number1;
                        }
                        if (s.Equals("/"))
                        {
                            ok = number2 / number1;
                        }
                        stack.Push(ok.ToString());
                    }
                }
                stack.Pop();
                return stack.Pop();
            }catch(Exception e)
            {
                PersonInput = "";
                return "Math Error !";
            }
        }
        public void onkeypressBackspace()
        {
            _MemoryDone = "";
            Result = "0";
            if (GetPersonInput().Length > 0)
            {
                String input = GetPersonInput().Substring(0, GetPersonInput().Length - 1);
                SetPersonInput(input);
            }
        }

        public String CheckInputPercentAndCommaAndDivZero(String PersonInput, String newInput)
        {
            if (PersonInput.EndsWith("+") || PersonInput.EndsWith("-") || PersonInput.EndsWith("*") || PersonInput.EndsWith("/"))
                if (newInput.Equals("%") || newInput.Equals(","))
                    return "";
            if (PersonInput.EndsWith("/") && newInput.Equals("0"))
                return "";
            if (PersonInput.Length == 0 && (PersonInput.EndsWith("+") || PersonInput.EndsWith("*") || PersonInput.EndsWith("/")))
                return "";
                return newInput;
        }
        public void SpamButtonDone()
        {
            if (PersonInput.EndsWith("."))
                PersonInput += "0";
            if (PersonInput.EndsWith("+") || PersonInput.EndsWith("-") || PersonInput.EndsWith("*") || PersonInput.EndsWith("/"))
                PersonInput = PersonInput.Substring(0, PersonInput.Length-1);
            if (!Result.Equals("0") && !Result.Equals("Math Error !"))
                PersonInput = Result;
                PersonInput += _MemoryDone;
            int check1 = -1;
            for(int i = PersonInput.Length-1; i>=0; i--)
            {
                if (OperatorOrOperand(PersonInput[i].ToString()) == 0 && !(PersonInput[i].ToString().Equals(",")) && !(PersonInput[i].ToString().Equals("%")))
                    check1 = i;
                if (check1 != -1 && OperatorOrOperand(PersonInput[i].ToString()) == 1)
                    break;
            }
            if (check1 > 0)
            {
                try
                {
                    int y = PersonInput.Substring(0, check1).Length;
                    _MemoryDone = PersonInput.Substring(check1, PersonInput.Length - y);
                }
                catch(Exception e)
                {
                    _MemoryDone = "";
                }
            }
            else
                _MemoryDone = "";
        }
    }
}
