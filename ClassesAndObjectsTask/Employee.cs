namespace ClassesAndObjectsTask
{
    public class Employee
    {
        private string surname;
        private int age;

        public Employee()
        {
            this.surname = string.Empty;
            this.age = 0;
        }

        public Employee(string surname, int age)
        {
            this.surname = surname;
            this.age = age;
        }

        public void ChangeSurname(string newSurname)
        {
            this.surname = newSurname;
        }

        public string GetEmployeeInfo()
        {
            return $"Surname: {this.surname}, Age: {this.age}";
        }

        private string GetAge()
        {
            return age.ToString();
        }
    }
}
