


using ConsoleApp1;
using ConsoleApp1.Helpers;
using System.ComponentModel;
using System.ComponentModel.Design;

#region HomeWork
//Console.WriteLine("Add your email:");
//string email = Console.ReadLine();


//var result = email.CheckEmail();

//if(result == false)
//{
//    Console.WriteLine("Wrong");
//}
//else
//{
//    Console.WriteLine("Success");
//}





//Console.WriteLine("Please add your email address");
//string email = Console.ReadLine();


//var result = email.CheckTrim(@"\s");

//if (result == false)
//{
//    Console.WriteLine("no");
//}
//else
//{
//    Console.WriteLine("yes");
//}



//Person person = new();

//person.Name = "Semed";
//person.Surname = "Huseynov";
//person.Id = 1;

//var result=person.GetFullData();
//Console.WriteLine(result);


//int[] number = { 1, 2, 3, 4, 5, 6, 7 };

//Console.WriteLine(number.GetMultiplyArray());
#endregion



//IntList list = new IntList();

//list.Add(1);
//list.Add(2);
//list.Add(3);
//list.Add(4);
//list.Add(5);
//list.Add(6);

//list.GetAll();


//StringList list =  new StringList();

//list.Add("Oruc");
//list.Add("Semed");
//list.Add("Nurlan");


//list.GetAll();


//PersonList person = new PersonList();

//person.Add(new Person { Id = 1 , Name = "Semed", Surname= "Huseynov"});
//person.Add(new Person { Id = 2 , Name = "Ferhad", Surname= "Fermanli"});
//person.Add(new Person { Id = 3 , Name = "Fidan", Surname= "Melikova"});
//person.Add(new Person { Id = 4 , Name = "Fidan", Surname= "Gehramanova"});


//person.GettAll();

//DataList<int> dataList = new();

//dataList.Add(1);
//dataList.Add(2);
//dataList.Add(3);
//dataList.Add(4);

//dataList.GetAll();

//DataList<string> dataList = new();

//dataList.Add("Salam");
//dataList.Add("Sagol");

//dataList.GetAll(); 


//DataList<Person> students = new();

//students.Add(new Person { Name = "Semed", Surname = "Huseynov" });
//students.Add(new Person { Name = "Elmir", Surname = "Seferov" });
//students.Add(new Person { Name = "Natiq", Surname = "Sadixli" });
//students.Add(new Person { Name = "Orxan", Surname = "Qasanovic" });

////students.GetAll();

//var res = students.GetAllStu();

//foreach (var item in res)
//{
//    Console.WriteLine(item.Name+" "+item.Surname);
//}

//List<Person> people = new();

//people.Add(new Person { Id = 1 , Name = "Semed" , Surname = "Huseynov"  });


//foreach (Person person in people)
//{
//    Console.WriteLine(person.Name);
//}

//Repository<string> repo1 = new Repository<string>();
//Repository<Person> repo4 = new Repository<Person>();
//Repository<int> repo2 = new Repository<int>();
//Repository<bool> repo3 = new Repository<bool>();
//Repository<Person, BaseEntity> test = new Repository<Person, BaseEntity>();






//DataList<string> words = new DataList<string>();

//words.Add("Salam1");
//words.Add("Salam2");
//words.Add("Salam3");

//words.GetAll();



//Repository<Person> repository = new Repository<Person>();
//repository.Add(new Person { Id = 1, Name = "Test1", Surname = "test2 " });


string payment = "Cash";

int tp = 2;
static void CheckPaymentType(string type)
{

    switch (type)
    {
        case nameof(PaymentType.Card):
            Console.WriteLine("Card");
            break;
        case nameof(PaymentType.Cash):
            Console.WriteLine("Cash");
            break;
        default:
            Console.WriteLine("Wrong");
            break;
            
    }




    //if (type == PaymentType.Card.ToString())
    //{
    //    Console.WriteLine("Card");
    //}else if (type == PaymentType.Cash.ToString())
    //{
    //    Console.WriteLine("Cash");
    //}
    //else
    //{
    //    Console.WriteLine("Wrong");
    //}
}

CheckPaymentType(payment);