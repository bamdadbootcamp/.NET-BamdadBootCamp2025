

using Session05;

//string[] firstNameArray = new string[0];
//string[] lastNameArray = new string[0];
//string[] nationalIdArray = new string[0];
//byte[] ageArray = new byte[0];

Person[] people = new Person[0];

do
{
    string firstNameValue;
    do
    {
        Console.WriteLine("Enter first name:");
        firstNameValue = Console.ReadLine();
        if (firstNameValue.Length > 2 && firstNameValue.Length < 100)
            break;
    } while (true);

    string lastNameValue;
    do
    {
        Console.WriteLine("Enter last name:");
        lastNameValue = Console.ReadLine();
        if (lastNameValue.Length > 2 && lastNameValue.Length < 100)
            break;
    } while (true);

    string nationalIdValue;
    do
    {
        Console.WriteLine("Enter national id:");
        nationalIdValue = Console.ReadLine();
        int temp = 0;
        bool isValid = int.TryParse(nationalIdValue, out temp);
        if (isValid && nationalIdValue.Length == 10)
            break;

    } while (true);

    byte ageValue = 0;
    do
    {
        Console.WriteLine("Enter age:");
        bool isValid = byte.TryParse(Console.ReadLine(), out ageValue);
        if (isValid && ageValue >= 18 && ageValue < 130)
            break;


    } while (true);

    Person person = new Person();
    person.firstName = firstNameValue;
    person.lastName = lastNameValue;
    person.nationalId = nationalIdValue;
    person.age = ageValue;

    Array.Resize(ref people, people.Length + 1);
    people[people.Length - 1] = person;

    //Array.Resize(ref firstNameArray, firstNameArray.Length + 1);
    //firstNameArray[firstNameArray.Length - 1] = firstNameValue;

    //Array.Resize(ref lastNameArray, lastNameArray.Length + 1);
    //lastNameArray[lastNameArray.Length - 1] = lastNameValue;

    //Array.Resize(ref nationalIdArray, nationalIdArray.Length + 1);
    //nationalIdArray[nationalIdArray.Length - 1] = nationalIdValue;

    //Array.Resize(ref ageArray, ageArray.Length + 1);
    //ageArray[ageArray.Length - 1] = ageValue;

    Console.WriteLine("If you want to add a new person enter Y");
    string input = Console.ReadLine();
    if (input.ToLower() != "y")
        break;

} while (true);

Console.Clear();

for (int i = 0; i < people.Length; i++)
{
    Helper.PrintPerson(people[i]);
    //Helper.PrintPerson(firstNameArray[i], lastNameArray[i]
    //    , nationalIdArray[i]
    //    , ageArray[i]);
    //Console.WriteLine($"First Name: {firstNameArray[i]}");
    //Console.WriteLine($"Last Name: {lastNameArray[i]}");
    //Console.WriteLine($"National Id: {nationalIdArray[i]}");
    //Console.WriteLine($"Age: {ageArray[i]}");
    Console.WriteLine();
    Console.WriteLine();
}

Console.WriteLine("Search national id");
string searchValue = Console.ReadLine();

Console.Clear();

bool isFound = false;
for (int i = 0; i < people.Length; i++)
{
    //if (nationalIdArray[i] == searchValue)
    if (people[i].nationalId == searchValue)
    {
        isFound = true;
        Helper.PrintPerson(people[i]);
        //Helper.PrintPerson(firstNameArray[i], lastNameArray[i]
        // , nationalIdArray[i]
        // , ageArray[i]);
        //Console.WriteLine($"First Name: {firstNameArray[i]}");
        //Console.WriteLine($"Last Name: {lastNameArray[i]}");
        //Console.WriteLine($"National Id: {nationalIdArray[i]}");
        //Console.WriteLine($"Age: {ageArray[i]}");
    }
}

if (!isFound)
{
    Console.WriteLine("User not found");
}

//// Complex Variables متغیر های پیچیده



// instance
//Person p1 = new Person();
//p1.firstName = "Mehrdad";
//p1.lastName = "Sharifi";
//p1.nationalId = "231321658";
//p1.age = 30;

//Person p2 = new Person();
//p2.firstName = "mohammad";
//p2.lastName = "rezaei";
//p2.nationalId = "123123";
//p2.age = 30;


