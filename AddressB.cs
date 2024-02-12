 class AddressBook
 {
     public string firstname { get; set; }
     public string lastname { get; set; }
     public string address {  get; set; }
     public string city { get; set; }
     public string state { get; set; }
     public int zipcode { get; set; }
     public string country { get; set; }
     public long phonenumber { get; set; }
     public string email { get; set; }
     public AddressBook(string firstname,string lastname,string address,string city,string state,int zipcode,string country,long phonenumber,string email)
     {
         this.firstname = firstname;
         this.lastname = lastname;
         this.address = address;
         this.city = city;
         this.state = state;
         this.zipcode = zipcode;
         this.country = country;
         this.phonenumber = phonenumber;
         this.email = email;
     }
 }
