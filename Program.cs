namespace Lesson12OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //לקבל את התאריך של היום להוסיף 3 ימים לתאריך ע"י adddays
            //להדפיס את התאריך בפורמט yyyy-MM-dd 
            //// DateTime dateTime = new DateTime(1991,01,03);
            //ליצור אובייקט מתוך מחלקה של datetime לפי תאריך 
            //2022/01/05
            //להדפיס את השנה חודש ויום כל אחד בשורה נפרדת
            var date = DateTime.Now.AddDays(3);
            Console.WriteLine(date.ToString("yyyy-MM-dd"));
            DateTime dateTime = new DateTime(2022, 01, 05);
            Console.WriteLine(dateTime.Year);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Day);





            // Console.WriteLine(dateTime);
            //Console.WriteLine(date);
            //Console.WriteLine(date.ToString("dd/MM/yyyy"));
            //Console.WriteLine(date.ToString("yyyy/MM/dd"));
            //Console.WriteLine(date.ToString("yyyy-MM-dd"));
            // Console.WriteLine(date.Month);

            //var path = @"C:\Users\yarin\Desktop\האקר יו לימודים\c# oop\Lesson12OOP\bin\Debug\net6.0\new\yarin16.txt";
            //string data = "bla bla";
            //File.WriteAllText(path, data);
            //File.Delete(path);
            //if (File.Exists(path))
            //{
            //    Console.WriteLine(StatusFile.Exist);
            //}
            //else
            //{
            //    Console.WriteLine(StatusFile.NotExist);
            //}



            //ליצור enum StatusFile
            //Exist
            //NotExist
            //ליצור קובץ
            //לכתוב לתוך הקובץ בלה בלה
            // לעשות בדיקה האם הקובץ קיים 
            //אם הקןבץ קיים 
            //להדפיס Exist מתוך הenum
            //אחרת להדפיס NotExist מתוך הenum

            //

            //int status = 0;

            //if(status == 1 )
            //status = (int)Status.StatusSuccess;
            //status = (int)Status.StatusFail;
            //string day = Days.Sunday.ToString();
            //if (status == 2)
            //{

            //}

            //var path = @"C:\Users\yarin\Desktop\האקר יו לימודים\c# oop\Lesson12OOP\bin\Debug\net6.0\new\yarin13.txt";
            //var destFileName = @"C:\Users\yarin\Desktop\האקר יו לימודים\c# oop\Lesson12OOP\bin\Debug\net6.0\new\move\yarin15.txt";
            //string data = "bla bla";
            //File.WriteAllText(path, data);//גם יוצרת את הקובץ וגם כותבת לקובץ
            //Console.WriteLine(File.ReadAllText(path));
            // File.Copy(path, destFileName);
            // File.Move(path, destFileName);
            //File.Delete(path);


            //if(File.Exists(path))
            //{
            //    Console.WriteLine("the file is Exists! ");
            //    File.WriteAllText()
            //}
            //else
            //{
            //    var file = File.Create(path);
            //    file.Close();

            //    Console.WriteLine("file created!");
            //}

        }
    }

    enum DocumentOperation
    {
        Load =1,
        Save =2,
        Discard =3
    }

    enum DocumentState
    {
        Saved =1,
        NotSaved =2
    }

    //enum int
    enum Status
    {
        //סטטוס הצלחה
        StatusSuccess = 1,
        StatusFail = 2,
    }

    // enum string
    enum Days
    {
        Sunday,

    }

    enum StatusFile
    {
        Exist,
        NotExist
    }
}