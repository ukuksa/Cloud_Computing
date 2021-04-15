using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XamarinLab3
{
    public class Models : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
 
        string firstName = "";

        public string FirstName
        {
            get => firstName;

            set
            {
                if (firstName == value)
                {
                    return;
                }
                firstName = value;
                OnPropertyChangedFirst(nameof(firstName));
                OnPropertyChangedFirst(nameof(DisplayName));
            }

        }

        public string DisplayName => $"Entered first name: {FirstName}";
        void OnPropertyChangedFirst(string firstName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(firstName));
        }


        string lastName = "";

        public string LastName
        {
            get => lastName;

            set
            {
                if (lastName == value)
                {
                    return;
                }
                lastName = value;
                OnPropertyChangedLast(nameof(lastName));
                OnPropertyChangedLast(nameof(DisplayLastName));
            }

        }

        public string DisplayLastName => $"Entered last name: {LastName}";

        void OnPropertyChangedLast(string lastName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(lastName));
        }


        string phoneNumber = "";

        public string PhoneNumber
        {
            get => phoneNumber;

            set
            {
                if (phoneNumber == value)
                {
                    return;
                }
                phoneNumber = value;
                OnPropertyChangedPhone(nameof(phoneNumber));
                OnPropertyChangedPhone(nameof(DisplayPhoneNumber));
            }

        }

        public string DisplayPhoneNumber => $"Entered first name: {PhoneNumber}";
        void OnPropertyChangedPhone(string phoneNumber)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(phoneNumber));
        }
    }
}
