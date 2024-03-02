/*See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
*/
using System;
using System.Collections.Generic;

public class Unemployed //Безработный

{
    public string Name { get; set; }
    public string SecondName { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string PassportNum { get; set; }
    public DateTime DateIssuePassport { get; set; }
    public string WhoIssuedPassport { get; set; }
    public string Adress { get; set; }
    public string PhoneNum { get; set; }
    public string Photography { get; set; }
    public string LevelEducation { get; set; }
    public string NameEducationalInstitution { get; set; }
    public string DataDocumentEducation { get; set; }
    public string Specialization { get; set; }
    public int WorkExperience { get; set; }
    public DateTime DateRegistration { get; set; }
}



public class Vacancy //Вакансия
{
    public string TypeJob { get; set; }
    public string NameJob { get; set; }
    public string NameEmployer { get; set; }
    public string AdressEmployer { get; set; }
    public string PhoneNumEmployer { get; set; }
    public decimal SalaryAmount { get; set; }
    public string SpecialRequirements { get; set; }
}

/*public class FactEmployment // факт трудоустройства
{
    public Unemployed Unemployed { get; set; }
    public Vacancy Vacancy { get; set; }
    public DateTime DateEmployment { get; set; }
}
*/

/*public class Stipend // Стипендия
{
    public Unemployed Unemployed { get; set; }
    public decimal AmountAllowance { get; set; }
}*/

/*public class Archive // Архив
{
    public Unemployed Unemployed { get; set; }
    public DateTime TransferDate { get; set; }
    public string PersonPerformedOperation { get; set; }
}
*/
