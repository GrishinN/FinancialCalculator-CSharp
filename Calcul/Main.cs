using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcul
{

    class Main
    {

        public string Сalculate(numberСharacteristic fNumber, numberСharacteristic sNumber, int operationNumber)
        {
            string result;
            StringBuilder res = new StringBuilder();
            switch (operationNumber) {
                case 0:
                    res.Append(Addition(fNumber, sNumber));
                    break;
                case 1:
                    res.Append(Subtraction(fNumber, sNumber));
                    break;
                case 2:
                    res.Append(Multiply(fNumber, sNumber));
                    res = MathRound(res, fNumber.point_position, sNumber.point_position);
                    break;
                case 3:
                    res.Append(Divide(fNumber, sNumber));
                    decimal ress = Math.Round(Decimal.Parse(res.ToString()),2,0);
                    res.Length = 0;
                    res.Append(ress);
                    fNumber.point_position = FormatResultDivide(res);
                    sNumber.point_position = 0;
                    break;
                default:
                    result = "";
                    break;
            }            
            return FormatResult(res , fNumber.point_position , sNumber.point_position).ToString();           
        }

        private StringBuilder Subtraction(numberСharacteristic fNumber, numberСharacteristic sNumber)
        {
            StringBuilder result = new StringBuilder();
            decimal firstNumber = Decimal.Parse(fNumber.value.ToString());
            decimal secondNumber = Decimal.Parse(sNumber.value.ToString());
            return result.Append(firstNumber - secondNumber);
        }

        private StringBuilder Addition(numberСharacteristic fNumber, numberСharacteristic sNumber)
        {
            StringBuilder resultNumber = new StringBuilder();
            decimal firstNumber = Decimal.Parse(fNumber.value.ToString());
            decimal secondNumber = Decimal.Parse(sNumber.value.ToString());
            return resultNumber.Append(firstNumber + secondNumber);
        }

        private StringBuilder Multiply(numberСharacteristic fNumber, numberСharacteristic sNumber)
        {
            StringBuilder resultNumber = new StringBuilder();
            decimal firstNumer = Decimal.Parse(fNumber.value.ToString());
            decimal secondNumber = Decimal.Parse(sNumber.value.ToString());
            return resultNumber.Append(Decimal.Multiply(firstNumer,secondNumber));
        }

        private StringBuilder Divide(numberСharacteristic fNumber, numberСharacteristic sNumber)
        {
            StringBuilder resultNumber = new StringBuilder();
            decimal firstNumber = Decimal.Parse(fNumber.value.ToString());
            decimal secondNumber = Decimal.Parse(sNumber.value.ToString());
            return resultNumber.Append(Decimal.Divide(firstNumber, secondNumber));
        }

        private StringBuilder FormatResultSpace(StringBuilder str , int pointPosition)
        {
            
            for (int i = pointPosition - 3; i >= 0; i = i - 3)
            {
                if((i - 1 >= 0 && str[i - 1] != '-'))
                {
                    str.Insert(i, ' ');
                }
                    
                

            }           
            return str;
        }
        
        private StringBuilder MathRound(StringBuilder str, int pointPosition1, int pointPosition2)
        {
            StringBuilder result = new StringBuilder();
            int res = pointPosition1 + pointPosition2;
            decimal number = 0;
            if (res == 3 )
            {
                if(str[str.Length - 1] >= 5)
                {
                    str.Remove(str.Length - 1, 1);
                    number = decimal.Parse(str.ToString()) + decimal.One;
                }
                return result.Append(number);
            }
            if (res == 4 )
            {
                if(str[str.Length - 2] >= 5)
                {
                    str.Remove(str.Length - 2, 2);
                    number = decimal.Parse(str.ToString()) + decimal.One;
                }
                return result.Append(number);
            }            
            return str;            
        }

        private StringBuilder FormatResult(StringBuilder str, int pointPosition1, int pointPosition2)
        {
            int length = str.Length;
            str.Replace(',', '.');
            if (pointPosition1 == 2 || pointPosition2 == 2)
            {
                if(str[length - 2] == '0' && str[length-1]== '0')
                {
                    str.Remove(length - 3, 3);                    
                    return FormatResultSpace(str, str.Length); ;
                }
                else
                {
                    if(str[length - 1] == '0')
                    {
                        FormatResultSpace(str, length - 3);
                        return str.Remove(length - 1,1);
                    }
                }
                return FormatResultSpace(str, length - 3);
            }
            else if(pointPosition1 != 0 || pointPosition2 != 0)
            {
                if (str[length - 1] == '0')
                {
                    FormatResultSpace(str, length - 2);
                    return str.Remove(str.Length - 2, 2);
                }
                return FormatResultSpace(str, length - 2);
            }            
            return FormatResultSpace(str, length);
        }

        private int FormatResultDivide (StringBuilder str)
        {
            str.Replace(',','.');
            for(int i = str.Length - 1 , point = 0; i >= str.Length - 3; i-- , point++)
            {
                if(str[i] == '.')
                {
                    return point;
                }
            }
            return 0;
        }
    }
}
