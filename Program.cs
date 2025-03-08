using practise;

Console.WriteLine("Hello, World!");


//Bike ob1 = new Bike();
//ob1.BInfo();
//ob1.DisplayInfo();
//Car ob2 = new Car();
//ob2.CInfo();
//ob2.DisplayInfo();

//BankAccount obj = new BankAccount();
//obj.HolderInfo();
//obj.WithDraw();
//obj.Deposit();

//StudentCredentials obj = new StudentCredentials();
//obj.StudentInfo();

//Books book = new Books();
//Books book1 = new Books("xyz", "zxc");
//Books book2 = new Books("dcxr", "rfdr", 1234567);

//Circle circle = new Circle(2);
//circle.Area();
//Rectangle rectangle = new Rectangle(2, 4);
//rectangle.Area();

//Vehicle vehicle = new Vehicle();
//vehicle.Start();
//car obj1 = new car();
//obj1.Start();
//bike obj2 = new bike();
//obj2.Start();

//PersonInfo person = new PersonInfo("person1",12);
//person.GetDetails();
//Teacher teacher = new Teacher("Teacher 1", 30, "Python");
//teacher.GetDetails();
//Student student = new Student("Student 1", 13, 1234, 7);
//student.GetDetails();

//Calculator calculator = new Calculator();
//calculator.Add(2, 4);
//calculator.Add(2, 4, 2);
//calculator.Add(2.4, 2.4);

//MusicPlayer music = new MusicPlayer();
//music.Play();
//VideoPlayer video= new VideoPlayer();
//video.Play();

//Report report = new Report("my report title", "my report cnotent");
//report.Print();
//report.Save("myreport.txt");

//Admin admin = new Admin("HOD");
//admin.AccessControl();
//Customer customer = new Customer("Studnet");
//customer.AccessControl();

//ComplexNumbers cn1 = new ComplexNumbers(1, 2);
//ComplexNumbers cn2 = new ComplexNumbers(1, 2);
//Console.WriteLine($"sum::{cn1+cn2}");

//SecuritySystem securitySystem = new SecuritySystem();
//securitySystem.AuthenticateUser("user", "password123");

//Logical logical = new Logical();
//Console.WriteLine(logical.IsPalindrome("avan"));
////logical.LeastElement();
//Console.WriteLine(logical.IsPrime());



//to check the highest max values
//Console.WriteLine(int.MaxValue);
//Console.WriteLine(Int16.MaxValue);
//Console.WriteLine(Int32.MaxValue);
//Console.WriteLine(Int64.MaxValue);
//Console.WriteLine(Int128.MaxValue);


//BasicCodes basicCodes = new BasicCodes();
//Console.WriteLine("reversed string::");
//Console.WriteLine(basicCodes.ReverseString("stringg"));
//Console.WriteLine("\nlarget element::");
//Console.WriteLine(basicCodes.LargestElement([3, 1, 2, 4, 56, 2]));
//Console.WriteLine("\nhashset example::");
//basicCodes.HashSetExample();
//Console.WriteLine("\nhashset to remove duplicates::");
//basicCodes.RemoveDuplicate([1, 2, 2, 34, 1, 77, 98]);
//Console.WriteLine("\ndictionary example::");
//basicCodes.DictExample();
//Console.WriteLine("\nfrequncy of elements in array using dictionary::");
//basicCodes.Frequencies([15,12,87,87,24,12,90,3,1,4,3,3]);
//Console.WriteLine("\npalindrome or not::");
//Console.WriteLine(basicCodes.IsPalindrome("malayalam"));
//Console.WriteLine("\nsum of array elements::");
//Console.WriteLine(basicCodes.ArraySum([1,2,3,4]));
//Console.WriteLine("\nmerge and sort arrays");
//basicCodes.MergeSortArrays([1, 3, 2], [5, 12]);


LeetCodee leetCodee = new LeetCodee();
Console.WriteLine("\nprint unique elements::");
leetCodee.RemoveDuplicates([1, 2, 2, 34, 1, 77, 98]);
