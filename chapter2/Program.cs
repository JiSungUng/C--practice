using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


/*    다음의 int와 String이 자료형에 해당.
변수 선언 : int var;
        String str;

    정수형: int -2,147,483,648이상 ~2,147,438,647이하만 저장 가능.
      은행관련업무 또는 돈관련 업무시 범위를 초과할 수 있으며,
      초과시 랜덤한 값이 들어가거나 오류가난다.
      long -9,223,372,036,854,775,808이상 ~+9,223,372,036,854,775,807이하만 저장 가능.
      short -32,768~32,767
      byte 0~255
논리형: bool true,false라는 참 거짓의 상태를 저장.
문자형: char 1개의 문자
문자열형: string 여러 문자를 저장.
실수형: float,double 소수점이있는 실수를 저장 할 수 있다.

사용자 정의 자료형:
        Class mycar{
        }
        클래스 생성후 Mycar라는 자료형 변수를 만들 수 있다.
Mycar supercar1;
*/




namespace chapter2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //형변환 (string->int)
            string money = "532";
            int money2 = 0;
            money2=Int32.Parse(money);

            //기본 int는  Int32를 사용.
            //Int64 저장할수 있는 숫자범위의 차이


            Console.WriteLine(money2);

            //형변환 (int->string)
            string txtmoney = "";
            txtmoney=money2.ToString();
            Console.WriteLine(txtmoney);

        }
    }
}
