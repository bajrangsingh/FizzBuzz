using System;
class HelloWorld {
  static void Main() {
    string[] strArray=new string[]{"1","3","5","","15","A","23"};
    //Console.WriteLine(strArray[0]);
    foreach(string item in strArray)
    {
        int a;
        bool isNum=int.TryParse(item,out a);
        if(isNum)
        {
            //int val=Convert.ToInt32(item);
            Console.WriteLine(writeFizzBuzz(a));
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid Item");
        }
        
    }
    
    //Console.WriteLine("Hello World");
  }
  
  public static string writeFizzBuzz(int val) // single responsibility
  {
      string outStr="";
      MyDivide myDiv=new MyDivide();
      if(myDiv.divideby3(val)!="" || myDiv.divideby5(val)!="")
      {
          if(myDiv.divideby3(val)!="" )
          outStr="Fizz";
          else
          outStr="Buzz";
      }
      else
      {
	    outStr ="Divided "+Convert.ToString(val)+" by 3\n";
	    outStr=outStr+"Divided "+Convert.ToString(val)+" by 5";
      }
      
      return outStr;
  }
  
}
interface divBase
{
    public string divideby3(int num);
    public string divideby5(int num);
}
public class MyDivide:divBase
{
    public string divideby3(int num)
    {
        if(num%3==0)
          return "Fizz";
        else 
          return "";
    }
    public string divideby5(int num)
    {
        if(num%5==0)
          return "Buzz";
        else 
          return "";
    }
}

