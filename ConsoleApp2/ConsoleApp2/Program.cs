
//string name = "Turxan";
//string surname = "Allahverdiyev";

//string name1 = "Turxan";
//string surname1 = "Allahverdiyev";



//var obj = new
//{
//    name= "Turxan",
//    surname = "Allahverdiyev",
//    age=22,
//    isMarried=false,
//    blabla=55,
//};



//Console.WriteLine(obj.name);

Student student = new Student();
Student student2 = new Student();

student.Name = "Ahmad";
student.SurName = "Mehdiyev";
student.Age = 23;

student.GettFullName();


class Student
{
    //Fields
    public string Name;
    public string SurName;
    public int Age;

    public void GettFullName()
    {
        Console.WriteLine($"Name: is {Name} Surname: is {SurName}");
    }
}













//string Sentence = "I study at code academy";


//string[] result = CustomSplit(Sentence,' ');

//for (int i = 0; i < result.Length; i++)
//{
//    Console.WriteLine(result[i]);
//}

//string[] CustomSplit(string data,char cr)
//{
//    string[] arr = { };
//    string value=string.Empty;
//    for(int i = 0; i < data.Length; i++)
//    {
//        if (data[i] == cr)
//        {
//            Array.Resize(ref arr,arr.Length+1);

//            arr[arr.Length - 1] = value;
//            value= string.Empty;
//        }

//        else
//        {
//            value += data[i];
//        }

//        if (i == data.Length - 1)
//        {
//            Array.Resize(ref arr, arr.Length + 1);

//            arr[arr.Length - 1] = value;
//        }

//    }
//    return arr;
//}

