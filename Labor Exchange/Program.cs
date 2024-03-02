
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Unemployed //Безработный

{

    private string _name;
    public string Name 
    {
        get
        {
            return _name;
        }
        set
        {
            if(Regex.IsMatch(value,@"[A-Z][a-z]{2,}"))
            {
                _name = value;
            }
            else
            {
                throw new Exception("invalid symbols in name!");
            }
        }
    }
    //сделат проверки на секонда наме и сурнаме + паспорт нум

    private string _secondname;
    public string SecondName 
    {
        get
        {
            return _secondname;
        }

        set
        {
            if (Regex.IsMatch(value, @"[A-Z][a-z]{2,}"))
            {
                _secondname = value;
            }
            else
            {
                throw new Exception("invalid symbols in secondname!");
            }
        }
    }
    private string _surname;
    public string Surname 
    {
        get
        {
            return _surname;
        }
        set
        {
            if (Regex.IsMatch(value, @"[A-Z][a-z]{2,}"))
            {
                _surname = value;
            }
            else
            {
                throw new Exception("invalid symbols in surname!");
            }
        }
    }

    public DateTime BirthDate { get; set; }

    public int CalculateAge()
    {
        DateTime currentDate = DateTime.Now;
        int age = currentDate.Year - BirthDate.Year;
        if (currentDate < BirthDate.AddYears(age))
        {
            age--;
        }
        return age;
    }

    //ЗАМЕНИТЬ НА ДАТУ РОЖДЕНИЕ
    //ДОБАВИТЬ МЕТОД, КОТОРЫ СЧИТАЕТ ВОЗРАСТ ПО ТЕКУЩЕЙ ДАТЕ И ДАТЕ РОЖДЕНИЯ

    private string _passportnum;

    public string PassportNum
    {
        get
        {
            return _passportnum;
        }
        set
        {
            if (Regex.IsMatch(value, @"^[0-9]{0,4}"))
            {
                _passportnum = value;
            }
            else
            {
                throw new Exception("invalid symbols in passport num!");
            }
        }
    }
    public DateTime DateIssuePassport { get; set; }
    public string WhoIssuedPassport { get; set; }
    public string Adress { get; set; }
    public string PhoneNum { get; set; }
    public string Photography { get; set; }
    public enum LevelEducation
                {
                    Elementary,
                    Primary,
                    Secondary,
                    Higher,
                    Postgraduate
                }
    //заменить на enum

    public string NameEducationalInstitution { get; set; }
    public string DataDocumentEducation { get; set; }
    public string Specialization { get; set; }


    public class PreviousJob
    {
        public string Company { get; set; }
        public string Position { get; set; }
        public string EmploymentPeriod { get; set; }
    }

    public List<PreviousJob> PreviousJobs { get; set; }

    public int TotalWorkExperience
    {
        get
        {
            int totalExperience = 0;
            foreach (PreviousJob job in PreviousJobs)
            {
                // Расчет стажа работы для каждого предыдущего места работы и добавление к общему стажу
                // Необходимо реализовать логику расчета стажа ...
                totalExperience += CalculateExperience(job.EmploymentPeriod);
            }
            return totalExperience;
        }
    }

    private int CalculateExperience(string employmentPeriod)
    {
        throw new NotImplementedException();
    }

    public void AddNewJob(string company, string position, string employmentPeriod)
    {
        // Проверка на пересечение периодов работы
        if (!IsEmploymentPeriodOverlap(employmentPeriod))
        {
            PreviousJob newJob = new PreviousJob
            {
                Company = company,
                Position = position,
                EmploymentPeriod = employmentPeriod
            };
            PreviousJobs.Add(newJob);
        }
        else
        {
            throw new Exception("Период работы пересекается с уже добавленными местами работы.");
        }
    }

    private bool IsEmploymentPeriodOverlap(string employmentPeriod)
    {
        throw new NotImplementedException();
    }


    //ЗАМЕНИТЬ НА СПИСОК ОБЪЕКТОВ КЛАССА С ПРОШЛЫМ МЕСТО РАБОТЫ (МЕСТО РАБОТЫ, ДОЛЖНОСТЬ, ПЕРИОД РАБОТЫ)
    //ДОБАВИТЬ ОТДЕЛЬНЫЙ МЕТОД ИЛИ СВОЙСТВО ДЛЯ РАСЧЕТА ОБЩЕГО СТАЖА РАБОТЫ
    //ДОБАВИТЬ МЕТОД ДОБАВЛЕНИЯ НОВОГО МЕСТА РАБОТЫ, ПРИ ДОБАВЛЕНИИ ПРОВЕРЯТЬ, ЧТО ДОБАВЛЯЕМЫЙ ПЕРИОД РАБОТЫ НЕ ПЕРЕСЕКАЕТСЯ ПО ВРЕМЕНИ С ТЕМ, ЧТО УЖЕ ДОБАВЛЕНО
    public DateTime DateRegistration { get; set; }
}



public class Vacancy //Вакансия
{
    //сюда тоде добавить проверки
    public enum JobType
    {
        ITandProgramming,
        MarketingandAdvertising,
        FinanceandAccounting,
        SalesandCustomerService,
        HealthcareandMedicine
    }
    public string NameJob { get; set; }
    public string NameEmployer { get; set; }
    public string AdressEmployer { get; set; }
    public string PhoneNumEmployer { get; set; }
    public decimal SalaryAmount { get; set; }

    public string SpecialRequirements { get; set; }
    //ДОБАВИТЬ LEVEL EDUCATION КАК ТРЕБОВАНИЕ К ВАКАНСИИ
    //ДОБАВИТЬ СПИСОК КАНДИДАТОВ НА ВАКАНСИЮ
    //ДОБАВИТЬ МЕТОД ДЛЯ ДОБАВЛЕНИЯ В СПИСОК КАНДИДАТОВ ОБЪЕКТА UNEMPLOYEE, ПРИ ДОБАВЛЕНИИ ПРОВЕРЯТЬ НА ДУБЛИ + УРОВЕНЬ ОБРАЗОВАНИЯ

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
