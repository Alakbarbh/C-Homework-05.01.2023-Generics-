
using Homework_05._01._2023_Generics_;
using Homework_05._01._2023_Generics_.Models;

#region Fibonacci
//Fibonacci(8);


//static void Fibonacci(int n)
//{
//    int a = 1;
//    int b = 1;
//    int c;

//    Console.WriteLine(a);
//    Console.WriteLine(b);

//    for (int i = 1; i <= n; i++)
//    {
//        c = a + b; //2

//        a = b; //1
//        b = c; //2

//        Console.WriteLine(c);
//    }
//}


//double for

//Test();

//static void Test()
//{
//    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, };
//    for (int i = 0; i < arr.Length; i++)
//    {
//        for (int j = 0; j < arr.Length - 1; j++)
//        {
//            Console.WriteLine(arr[i] + " " + arr[j]);
//        }


//    }
//}


#endregion
#region Student
//static void ShowSameStudentsCount()
//{
//    Student stu1 = new Student()
//    {
//        Id= 1,
//        Name = "Eycahan"
//    };

//    Student stu2 = new Student()
//    {
//        Id = 2,
//        Name = "Eycahan"
//    };

//    Student stu3 = new Student()
//    {
//        Id = 3,
//        Name = "Eycahan"
//    };

//    Student stu4 = new Student()
//    {
//        Id = 4,
//        Name = "Eycahan"
//    };

//    Student[] students = { stu1, stu2, stu3, stu4 };
//    int count = 0;
//    for (int i = 0; i < students.Length; i++)
//    {
//        for (int j = 1; j < students.Length - 1; j++)
//        {
//            if (students[i].Name == students[j].Name)
//            {
//                count++;
//            }
//        }
//    }
//    Console.WriteLine(count);
//}
#endregion
#region Manat cover Dollar

//Manat manat = new Manat(340);

//Dollar dollar = manat;

//Console.WriteLine(dollar.Usd);
#endregion


//StringList list1 = new StringList();

//list1.Add("Eycahan");
//list1.Add("Masin yeyen Ferid");
//list1.Add("Cahangest Veteranli");
//list1.GetAll();

//IntList list2 = new IntList();

//list2.Add(1);
//list2.Add(2);
//list2.Add(3);
//list2.Add(4);
//list2.GetAll();


//StudentList list3 = new StudentList();

//list3.Add(new Student { Id = 1, Name = "Eycahan" });
//list3.Add(new Student { Id = 2, Name = "Cahangest Veteranli" });
//list3.Add(new Student { Id = 3, Name = "Mirze S class" });
//list3.GetAll();



//DataList<string> students= new DataList<string>();

//students.Add("Eycahan");
//students.Add("Masin yeyen Ferid");
//students.Add("Cahangest Veteranli");
//students.GetAll();

//DataList<int> numbers = new DataList<int>();

//numbers.Add(1);
//numbers.Add(2);
//numbers.Add(3);
//numbers.Add(4);
//numbers.GetAll();

//DataList<Student> studentList= new DataList<Student>();

//studentList.Add(new Student { Id = 1, Name = "Mubariz" });
//studentList.Add(new Student { Id = 2, Name = "Ekshin" });
//studentList.Add(new Student { Id = 3, Name = "Cavid" });
//studentList.GetAll();


//List<int> nums = new List<int>();

//nums.Add(100);
//nums.Add(22);

////foreach (var item in nums)
////{
////    Console.WriteLine(item);
////}

//for (int i = 0; i <= nums.Count; i++)
//{
//	for (int j = i; j <= nums.Count - 1; j++)
//	{
//		if (nums[i] > nums[j])
//		{
//			Console.WriteLine("Boyukdur");
//			break;
//		}
//	}
//}



//Repository<Studentt> student = new Repository<Studentt>();

//Repository<int> num= new Repository<int>();

//Repository<string> str = new Repository<string>();

//Repository<bool> married = new Repository<bool>();

//Repository<Test1, Test2> data = new Repository<Test1, Test2>();