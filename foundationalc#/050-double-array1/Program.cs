// Complete the challenge to display email addresses
// Create a method that displays that correct email address for both internal and external employees
// Add method to display email addresses
string[,] corporate = 
{
    {"Robert", "Bavin"}, 
    {"Simon", "Bright"},
    {"Kim", "Sinclair"}, 
    {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, 
    {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

bool isExternal = true;
// string[,] email = {};

string externalDomain = "hayworth.com";
string corporateDomain = "contoso.com";

// for (int i = 0; i < corporate.GetLength(0); i++)
// {
//     Console.WriteLine(corporate[i]);
// }

// for (int i = 0; i < external.GetLength(0); i++)
// {
//     Console.WriteLine(external[i]);
// }

//string[] first_names = new string[];

// for (int i = 0; i < corporate.GetLength(0); i++)
// {
//     for (int j = 0; j < corporate.GetLength(1); j++)
//     {
//         // string first_name = corporate[i, 0];
//         // string last_name = corporate[i, 1];
//         // Console.WriteLine(first_name, last_name);
//         // Console.WriteLine(corporate[i])
//         // string name = corporate[i, j].ToLower();
//         // Console.Write(name.ToLower());

//     }
//     Console.WriteLine();
// }

void createEmails(string[] namesFormat, string email_suffix)
{
    string[] emails = new string[namesFormat.Length];
    for (int i = 0; i < namesFormat.Length; i++)
    {
        emails[i] = $"{namesFormat[i]}{email_suffix}";
    }
    
    foreach (string email in emails)
    {
        Console.WriteLine(email);
    }
}

static string[] getNames(string[,] names)
{
    // string[] first_names = new string[names.GetLength(0)];
    // string[] last_names = new string[names.GetLength(0)];
    string[] namesFormat = new string[names.GetLength(0)];
    for (int i = 0; i < names.GetLength(0); i++)
    {
        string first = names[i, 0].ToLower().Substring(0,2);
        string last = names[i, 1].ToLower();

        string first_part = first.Length >= 2 ? first.Substring(0,2) : first;

        namesFormat[i] = first_part + last + "@";
    }  
    return namesFormat;
}

// if (isExternal)
// {
    
// }
// else
// {
    
// }

createEmails(getNames(corporate), corporateDomain);
createEmails(getNames(external), externalDomain);

// Much Simpler Solution
string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
}

void DisplayEmail(string first, string last, string domain = "contoso.com") 
{
    string email = first.Substring(0, 2) + last;
    email = email.ToLower();
    Console.WriteLine($"{email}@{domain}");
}