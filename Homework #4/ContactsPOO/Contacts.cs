//Jambriel Calderon Ortiz 2025-0914

namespace ContactsPOO
{
    class Contacto
    {
        public string name { get; set; }
        public string phone { get; set; } 
        public string email { get; set; }
        public string address { get; set; }


        public Contacto(
        string name,
        string phone,
        string email,
        string address)
        {
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.address = address;
        }

        public Contacto()
        {

        }
    }

}