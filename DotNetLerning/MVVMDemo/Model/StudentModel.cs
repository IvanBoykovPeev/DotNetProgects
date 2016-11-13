using System;
using System.ComponentModel;

namespace MVVMDemo.Model
{
    public class StudentModel
    {
    }

    public class Student : INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                if (firstName != value)
                {
                    firstName = value;
                    RaisePropertyCanged("FirstName");
                    RaisePropertyCanged("FullName");
                }
            }
        }

        public string LastName
        {
            get { return lastName; }

            set
            {
                if (lastName != value)
                {
                    lastName = value;
                    RaisePropertyCanged("LastName");
                    RaisePropertyCanged("FullName");
                }
            }
        }

        public string FullName
        {
            get
            {
                return firstName + lastName;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyCanged(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

    }
}
