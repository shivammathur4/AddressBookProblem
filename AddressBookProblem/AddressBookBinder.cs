using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBookProblem.Day_20_AddressBook;

namespace AddressBookProblem
{
    class AddressBookBinder
    {
        //Address books store with address book name as key
        public Dictionary<string, List<Contact>> Binder = new Dictionary<string, List<Contact>>();
        //Dictionary of contacts seggregated citywise
        public Dictionary<string, List<Contact>> CityDictionary = new Dictionary<string, List<Contact>>();

        /// <summary>
        /// Adds the addr book.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="set">The set.</param>
        /// <returns></returns>
        //Creating Different AddressBooks
        public List<Contact> AddAddrBook(string key, List<Contact> set)
        {
            if (this.Binder.ContainsKey(key))
            {
                Console.WriteLine("Address book already exists");
                return Binder[key];
            }
            else
            {
                Console.WriteLine("New address book created");
                Binder.Add(key, set);
                return Binder[key];
            }
        }

        /// <summary>
        /// Distincts the cities.
        /// </summary>
        /// <returns></returns>
         //List of different cities whose contact exists is created
        public List<string> DistinctCities()
        {
            List<string> city = new List<string>();
            foreach (var key in Binder.Keys)
            {
                foreach (Contact c in Binder[key])
                {
                    if (city.Contains(c.City))
                        continue;
                    else
                        city.Add(c.City);
                }
            }
            return city;
        }

        /// <summary>
        /// Creates the dictionary.
        /// </summary>
        //Creating Dictionary with city as a key
        public void CreateDictionary()
        {
            //creates a list
            List<string> City1 = DistinctCities();
            //traverse through city
            foreach (string city in City1)
            {
                //creates a list
                List<Contact> CityContact = new List<Contact>();
                foreach (var key in Binder.Keys)
                {
                    //traverse through contact in binder
                    //if city matches
                    //then that city will be added
                    foreach (Contact c in Binder[key])
                    {
                        if (c.City == city)
                            CityContact.Add(c);
                    }
                }
                //determines whether dictionary contains specified key value
                //returns true if that dictionary key value matches with the specified key
                //and adds that contact
                //In else part if that key value is not found
                //then the keyvalue will be added i.e the city is added to dictionary
                if (this.CityDictionary.ContainsKey(city))
                    CityDictionary[city] = CityContact;
                else
                    CityDictionary.Add(city, CityContact);
            }
        }
    }
}
