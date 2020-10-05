using System;
using System.Collections.Generic;
using System.Data;

namespace BlazorApp_WordProcessing
{
    class SampleData
    {
        DataTable dataTable;

        public SampleData()
        {
            dataTable = new DataTable();
            CreateDataTableColumns(dataTable);
            RecipientList = CreateRecipientList();
            SenderList = CreateSenderList();
        }

        public List<Recipient> RecipientList { get; }
        public List<Sender> SenderList { get; }

        void CreateDataTableColumns(DataTable dataTable)
        {
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Title", typeof(string));
            dataTable.Columns.Add("CompanyName", typeof(string));
            dataTable.Columns.Add("ContactName", typeof(string));
            dataTable.Columns.Add("ContactTitle", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("PostalCode", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
        }

        List<Recipient> CreateRecipientList()
        {
            return new List<Recipient>() {
                new Recipient("Alfreds Futterkiste", "Maria Anders", "Sales Representative",
                "Obere Str. 57", "Berlin", "12209", "mariaanders@example.com"),
                new Recipient("Ana Trujillo Emparedados y helados", "Ana Trujillo", "Owner", "Avda. de la Constitucion, 2222", "Mexico D.F.", "5021", "anatrujillo@example.com"),
                new Recipient("Antonio Moreno Taqueria", "Antonio Moreno", "Owner", "Mataderos  2312", "Mexico D.F.", "5023", "antoniomoreno@example.com"),
                new Recipient("Around the Horn", "Thomas Hardy", "Sales Representative", "120 Hanover Sq.", "London", "WA1 1DP", "thomashardy@example.com"),
                new Recipient("Berglunds snabbkop", "Christina Berglund", "Order Administrator", "Berguvsvegen  8", "Luleе", "S-958 22", "christinaberglund@example.com"),
                new Recipient("Blauer See Delikatessen", "Hanna Moos", "Sales Representative", "Forsterstr. 57", "Mannheim", "68306", "hannamoos@example.com"),
                new Recipient("Blondel pure et fils", "Frederique Citeaux", "Marketing Manager", "24 Place Kleber", "Strasbourg", "67000", "frederiqueciteaux@example.com"),
                new Recipient("Bolido Comidas preparadas", "Martin Sommer", "Owner", "C-Araquil, 67", "Madrid", "28023", "martinsommer@example.com"),
                new Recipient("Bon app'", "Laurence Lebihan", "Owner", "12, rue des Bouchers", "Marseille", "13008", "laurencelebihan@example.com")
            };
        }

        List<Sender> CreateSenderList()
        {
            return new List<Sender>() {
                new Sender("Nancy", "Davolio", "Sales Representative"),
                new Sender("Andrew", "Fuller", "Vice President, Sales"),
                new Sender("Janet", "Leverling", "Sales Representative"),
                new Sender("Margaret", "Peacock", "Sales Representative"),
                new Sender("Steven", "Buchanan", "Sales Manager")
            };
        }

        public DataTable GetDataSource(Sender sender, Recipient recipient)
        {
            dataTable.Rows.Clear();
            dataTable.Rows.Add(sender.FirstName,
                                sender.LastName,
                                sender.Title,
                                recipient.CompanyName,
                                recipient.ContactName,
                                recipient.ContactTitle,
                                recipient.Address,
                                recipient.City,
                                recipient.PostalCode,
                                recipient.Email);
            return dataTable;
        }
    }

    public class Recipient
    {
        public Recipient(string companyName, string contactName, string contactTitle,
            string address, string city, string postalCode, string email)
        {
            CompanyName = companyName;
            ContactName = contactName;
            ContactTitle = contactTitle;
            Address = address;
            City = city;
            PostalCode = postalCode;
            Email = email;
        }

        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }
    }

    public class Sender
    {
        public Sender(string firstName, string lastName, string title)
        {
            FirstName = firstName;
            LastName = lastName;
            Title = title;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
