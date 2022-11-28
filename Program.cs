namespace Lesson12OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
}