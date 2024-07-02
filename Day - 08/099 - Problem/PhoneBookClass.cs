namespace PhoneBookClassProblem
{
    class PhoneBookClass
    {
        public static void Solution()
        {
            PhoneBook phoneBook1 = new PhoneBook();
            Console.WriteLine(phoneBook1.GetNumberPages());

            PhoneBook phoneBook = new PhoneBook(21);
            Console.WriteLine(phoneBook.GetNumberPages());

            BigPhotoBook bigPhotoBook1 = new BigPhotoBook();
            Console.WriteLine(bigPhotoBook1.GetNumberPages());
        }
    }
    class PhoneBook
    {
        protected int nNumPages;
        
        public PhoneBook()
        {
            nNumPages = 16;
        }
        public PhoneBook(int nNumPages)
        {
            this.nNumPages = nNumPages;
        }
        public int GetNumberPages()
        {
            return nNumPages;
        }
    }
    class BigPhotoBook:PhoneBook
    {
        public BigPhotoBook()
        {
            nNumPages = 64;
        }
    }
}
