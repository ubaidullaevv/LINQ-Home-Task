using Domain;
List<Employee> employees=new List<Employee>()
    {
        new Employee{Age=18,Email="jhgfd@hgfghj.com",Experience=2,FirstName="John",LastName="DFGH",Id=1,Salary=2209},
        new Employee{Age=28,Email="fghjk@nhbgvf.com",Experience=5,FirstName="Ali",LastName="Alzoda",Id=2,Salary=6000},
        new Employee{Age=22,Email="cghj@hgfghj.com",Experience=3,FirstName="Vali",LastName="Kodirov",Id=3,Salary=3000},
        new Employee{Age=17,Email="cvgbhn@hgfghj.com",Experience=0,FirstName="Mahmud",LastName="John",Id=4,Salary=2000},
        new Employee{Age=30,Email="dfghjh@hgfghj.com",Experience=10,FirstName="Abu",LastName="Bandit",Id=5,Salary=500},
        new Employee{Age=21,Email="dtfyugi@hgfghj.com",Experience=1,FirstName="Xaba",LastName="Pm",Id=6,Salary=9000},
        new Employee{Age=25,Email="trytuykh@hgfghj.com",Experience=3,FirstName="Woga",LastName="Chau",Id=7,Salary=1500}
    };

// 1----------------------------------------------------------------
//     List<Employee> employees=new List<Employee>()
//     {
//         new Employee{Age=18,Email="jhgfd@hgfghj.com",Experience=2,FirstName="John",LastName="DFGH",Id=1,Salary=2209},
//         new Employee{Age=28,Email="fghjk@nhbgvf.com",Experience=5,FirstName="Ali",LastName="Alzoda",Id=2,Salary=6000},
//         new Employee{Age=22,Email="cghj@hgfghj.com",Experience=3,FirstName="Vali",LastName="Kodirov",Id=3,Salary=300},
//         new Employee{Age=17,Email="cvgbhn@hgfghj.com",Experience=0,FirstName="Mahmud",LastName="John",Id=4,Salary=10000},
//         new Employee{Age=30,Email="dfghjh@hgfghj.com",Experience=10,FirstName="Abu",LastName="Bandit",Id=5,Salary=2209},
//         new Employee{Age=21,Email="dtfyugi@hgfghj.com",Experience=1,FirstName="Xaba",LastName="Pm",Id=6,Salary=2209},
//         new Employee{Age=25,Email="trytuykh@hgfghj.com",Experience=3,FirstName="Woga",LastName="Chau",Id=7,Salary=2209}
//     };
    
// foreach (var item in employees)
// {
//     System.Console.WriteLine(item.Salary);
// }

// 2----------------------------------------------------------------



// var names=employees.Where(e=>e.FirstName.Length>6).ToList();

// foreach (var item in names)
// {
//     System.Console.WriteLine(item.FirstName);
// }

// 3----------------------------------------------------------------


// var emp=employees.Select(e=>e.Age).First();

// var emp2=employees.Where(e=>e.Age>emp).ToList();


// foreach (var item in emp2)
// {
//     System.Console.WriteLine(item.FirstName + " " + item.LastName);
// }

// 4----------------------------------------------------------------


// var emp=employees.Where(e=>e.Experience*2<e.Age).ToList();

// foreach (var item in emp)
// {
//     System.Console.WriteLine(item.FirstName + " " + item.LastName);
// }

// 5----------------------------------------------------------------


// var experts=employees.OrderByDescending(x=>x.Experience).Take(3).Where(e=>e.Salary>5000).ToList();


// foreach (var item in experts)
// {
//  System.Console.WriteLine(item.FirstName);   
// }

