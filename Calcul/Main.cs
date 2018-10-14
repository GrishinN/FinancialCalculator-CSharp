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
            StringBuilder result = new StringBuilder();
            switch (operationNumber) {
                case 0:
                    result.Append(Addition(fNumber, sNumber));
                    break;
                case 1:
                    result.Append(Subtraction(fNumber, sNumber));
                    break;
                case 2:
                    result.Append(Multiply(fNumber, sNumber));                   
                    decimal resultNumber = Math.Round(Decimal.Parse(result.ToString()), 2, 0);
                    result.Length = 0;
                    result.Append(resultNumber);
                    break;
                case 3:
                    result.Append(Divide(fNumber, sNumber));
                    decimal resNumber = Math.Round(Decimal.Parse(result.ToString()),2,0);
                    result.Length = 0;
                    result.Append(resNumber);
                    fNumber.point_position = FormatResultDivide(result);
                    sNumber.point_position = 0;
                    break;
                default:
                    break;
            }            
            return FormatResult(result , fNumber.point_position , sNumber.point_position).ToString();           
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
            for(int i = str.Length - 1 , point = 0; i >= str.Length - 3 && i >= 0 ; i-- , point++)
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
