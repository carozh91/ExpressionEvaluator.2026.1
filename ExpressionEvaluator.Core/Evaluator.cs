namespace ExpressionEvaluator.Core;

public class Evaluator
{
    public static double Evaluate(string infix)
    {
        var postfix = InfixToPostfix(infix);
        return EvaluatePostfix(postfix);
    }

    private static string InfixToPostfix(string infix)
    {
        var postFix = string.Empty;
        var stack = new Stack<char>();
        var number = "";
        foreach (var item in infix)
        {
            if (char.IsDigit(item) || item == '.')
            {
                number += item;
            }
            else if (IsOperator(item))
            {
                if (number != "")
                {
                    postFix += number + " ";
                    number = "";
                }

                if (stack.Count == 0)
                {
                    stack.Push(item);
                }
                else
                {
                    if (item == ')')
                    {
                        do
                        {
                            postFix += stack.Pop() + " ";
                        } while (stack.Peek() != '(');
                        stack.Pop();
                    }
                    else
                    {
                        if (PriorityInfix(item) > PriorityStack(stack.Peek()))
                        {
                            stack.Push(item);
                        }
                        else
                        {
                            postFix += stack.Pop() + " ";
                            stack.Push(item);
                        }
                    }
                }
            }

        }
        if (number != "")
        {
            postFix += number + " ";
        }

        
        while (stack.Count > 0)
        {
            postFix += stack.Pop() + " ";
        }
        return postFix.Trim();
    }

    private static int PriorityStack(char item) => item switch
    {
        '^' => 3,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 0,
        _ => throw new Exception("Sintax error."),
    };

    private static int PriorityInfix(char item) => item switch
    {
        '^' => 4,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 5,
        _ => throw new Exception("Sintax error."),
    };

    private static double EvaluatePostfix(string postfix)
    {
        var stack = new Stack<double>();
        var number = "";
        foreach (char item in postfix)
        
        {
            if (char.IsDigit(item) || item == '.')
            {
                number += item;
            }
            else if ( item == ' ')
            {
                if (number != "")
                {
                    stack.Push(double.Parse(number, System.Globalization.CultureInfo.InvariantCulture));
                    number = "";
                }

            }
            else if (IsOperator(item))
            {
                if (number != "")
                {
                    stack.Push(double.Parse(number, System.Globalization.CultureInfo.InvariantCulture));
                    number = "";
                }

                var b = stack.Pop();
                var a = stack.Pop();
                stack.Push(item switch
                {
                    '+' => a + b,
                    '-' => a - b,
                    '*' => a * b,
                    '/' => a / b,
                    '^' => Math.Pow(a, b),
                    _ => throw new Exception("Sintax error."),
                });
            }
            
        }
        if (number != "")
        {
            stack.Push(double.Parse(number, System.Globalization.CultureInfo.InvariantCulture));
        }
        return stack.Pop();
    }

    private static bool IsOperator(char item) => "+-*/^()".Contains(item);
}