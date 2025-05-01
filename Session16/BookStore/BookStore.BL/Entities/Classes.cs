
using System.Collections;

namespace BookStore.BL.Entities;

public class InstanceMember : AbstractClass // Instance Member
{
    public InstanceMember()
    {
    }
    // FIELD => private
    // PROPERTY => public
    // METHOD => public / private
    // CONSTRUCTOR => public 
    // EVENT

    // باید از این کلاس نمونه گرفت تا به اجزای آن دسترسی داشته باشیم
    // قابلیت ارث برری دارند
}

public abstract class AbstractClass
{
    public string Name { get; set; }
    protected int Number { get; set; }

    // قابلیت نمونه گیری ندارد
    // قابلیت ارث بری دارد
}

public sealed class SealedClass
{
    // این کلاس قابلیت نمونه گیری دارد
    // کلاس های دیگر از این کلاس نمیتوانند ارث بری کنند
}

public static class StaticClass
{
    // این کلاس بدون نیاز به نمونه گیری به اجزای آن دسترسی میتوان داشت
}



public class Test
{
    public Test()
    {
        InstanceMember instanceMember = new InstanceMember();
        instanceMember.Name = "test";
        

        //SealedClass sealedClass = new SealedClass();

        //string date = "1404/02/11";

        //CalendarUtility.Shamsi2Gregorian(date);

        DateTime dateTime = DateTime.Now;
        string text = "salam";

        string t1 = CalendarUtility.Gregorian2Shamsi(dateTime, '/');

        string t2 = dateTime.Gregorian2Shamsi('/');


        int[] array = new int[3];
        array[0] = 1;

        ArrayList arrayList = new ArrayList();
      
        // NOT SAFE
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add("Hello");
        arrayList.Add(dateTime);

        arrayList.Remove(2);
        arrayList.RemoveAt(1);


    }
}