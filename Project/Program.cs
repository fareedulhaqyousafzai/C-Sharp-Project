using Project;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using static Project.Inheritance;
using static Project.InheritanceTypes;
using static Project.Polymorphism_Dynamic;

//DataTypes.PrimativeDataTypes();
//DataTypes.derivedDataTypes();
//DataTypeConversion.DataTypeConversion_fun();
//NewFuncation obj = new NewFuncation();
//obj.getdata();
//obj.add();
//obj.sub();
//obj.mul();
//obj.div();

//NewPro.forstatic();

//NewPro obj = new NewPro();
//obj.forinstance();

//Console.WriteLine(NewPro.name);

//SwapProgram.swap();
//SimpleInterestCalculate.CalculateSimpleInterest();
//CompoundInterestCalculate.CalculateInterestCompound();
//Circle_TriangleCalculate.CalculateCircleArea();
//Feet_to_Inch_Inch_to_Feet_Convert.ConvertFeetToInches();
//Digit_Number_Reverse.ReverseNumber();

//BoxingExample.Boxing();
//BoxingExample.UnBoxing();


//Unary_Operators.PostIncrement();
//Unary_Operators.PreIncrement();
//Unary_Operators.PostDecrement();
//Unary_Operators.PreDecrement();
//Ternary_Operator.CheckAge();
//Ternary_Operator.oddEven();
//Ternary_Operator.loopyear();
//Ternary_Operator.NumberDivisibleBy3And5();
//Ternary_Operator.oddEven();
//If.EvenCheck();
//If_else.agecheck();
//If_else_If.PercentageCalculator();
//Switch.AlphabetBook();
//Loops.ForLoop();
//Table.PrintTable();
//Factorail.CalculateFactorial();
//Loops.WhileLoop();
//Loops.DoWhileLoop();
//Loops.NestedLoops();
//Project.Array.ArrayExample();

//Student_card_OOP[] obj = new Student_card_OOP[5];
//for (int i = 0; i < obj.Length; i++)
//{
//    Console.WriteLine($"\n--- Enter Details for Student {i + 1} ---");
//    obj[i] = new Student_card_OOP();
//    obj[i].getdata();
//}
//Console.WriteLine("\n=======================");
//Console.WriteLine(" All Student Details   ");
//Console.WriteLine("=======================");

//foreach (Student_card_OOP student in obj)
//{
//    student.displaydata();
//    Console.WriteLine("-----------------------"); 
//}


//Constructor obj1 = new Constructor();


//Constructor obj2 = new Constructor("Ali", 101);
//obj2.ShowData();

//Constructor obj3 = new Constructor("Fareed", 102, 24);
//obj3.ShowData();

//Constructor copy_obj3 = new Constructor(obj3);
//copy_obj3.ShowData();

//Constructor.Example.GetTime();
//Constructor.Example.a = 20;
//Console.WriteLine(Constructor.Example.Incerement());

//Properties obj = new Properties();
//obj.StudentId = 101;
//obj.StudentName = "Nazeer";

//Console.WriteLine($"Student ID: {obj.StudentId}, Student Name: {obj.StudentName}");

//PropertieTypes obj2 = new PropertieTypes();
//obj2.Id = 101;
//obj2.Name= "Fareed";


//Console.WriteLine($"Student ID: {obj2.Id}, Student Name: {obj2.Name}");

//PropertieTypes s = new PropertieTypes(102, "Ali");

//Console.WriteLine($"Student ID: {s.Id}, Student Name: {s.Name}");

//Encapsulation p = new Encapsulation();
//p.SetId(1258119);
//p.GetId();
//p.SetName("Fareed");
//p.GetName();

//Polymorphism_Static obj = new Polymorphism_Static();
//obj.Add();
//obj.Add(15, 25);
//obj.Add(10,20,30);
//obj.Add("Fareed", "Khan");

//PermanentEmployee Fareed = new PermanentEmployee();
//Fareed.EmpName="Fareed";
//Fareed.Empid=1250;
//Fareed.PermanentEmpSalary = 60000;

//Console.WriteLine("Permanent Employee Details");
//Console.WriteLine($"Employee Name is :{Fareed.EmpName}, Employee ID is:{Fareed.Empid},Employee Salary is:{Fareed.PermanentEmpSalary}");

//ContractEmployee Nazeer = new ContractEmployee();
//Nazeer.EmpName = "Nazeer";
//Nazeer.Empid =1234;
//Nazeer.ContractEmpSalary = 40000;

//Console.WriteLine("Contract Employee Details");
//Console.WriteLine($"Employee Name is :{Nazeer.EmpName}, Employee ID is:{Nazeer.Empid},Employee Salary is:{Nazeer.ContractEmpSalary}");

//DerivedClass obj = new DerivedClass();
//obj.Show();
//obj.show2();


//NewPermanentEmployee Fareed = new NewPermanentEmployee();
//Fareed.EmpName = "Fareed";
//Fareed.Empid = 1250;
//Fareed.PermanentEmpSalary = 60000;

//Console.WriteLine("Permanent Employee Details");
//Console.WriteLine($"Employee Name is :{Fareed.EmpName}, Employee ID is:{Fareed.Empid},Employee Salary is:{Fareed.PermanentEmpSalary}");

//NewContractEmployee Nazeer = new NewContractEmployee();
//Nazeer.EmpName = "Nazeer";
//Nazeer.Empid = 1234;
//Nazeer.ContractEmpSalary = 40000;

//Console.WriteLine("Contract Employee Details");
//Console.WriteLine($"Employee Name is :{Nazeer.EmpName}, Employee ID is:{Nazeer.Empid},Employee Salary is:{Nazeer.ContractEmpSalary}");

//Manager m1 = new Manager();

//m1.Name = "Fareed";
//m1.EmployeeId = 1250;
//m1.DepartmentName = "IT Department";

//Console.WriteLine($"Name: {m1.Name}, ID: {m1.EmployeeId}, Dept: {m1.DepartmentName}");


//m1.Eat();        
//m1.Work();
//m1.ManageTeam();

//Parent obj = new Child();
//obj.Print();

//Par obj2 = new Chil();
//obj.Print();

Employeee fareed = new Employeee(1250, "Fareed", 50000);
fareed.ShowEmployeeDetails(); 

Employeee nazeer = new Employeee(1234, "Nazeer", 35000);
nazeer.ShowEmployeeDetails(); 
