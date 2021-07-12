/**7.Create a class "PhotoAlbum" with a private attribute "numberOfPages."**/

using System;

namespace july
{
    public class PhotoBook 
    {
        //Protected class instead of private
        protected int numPages;
        public int GetNumberPages()
        {
            return numPages;
        }
        // Defined the default consturctor
        public PhotoBook()
        {
            numPages = 16;
        }
        // Parameterized constructor where we specfic no.of pages
        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
        }
    }
    // Inhertiance concept for BigPhotoBook
    public class BigPhotoBook : PhotoBook 
    {
        // Defined the constructor
        public BigPhotoBook()
        {
            numPages = 64;
        }
    }
    public class PhotoBookTest
    {
        public static void Main()
        {
            PhotoBook b1= new PhotoBook();
            Console.WriteLine("\nFirst photobook pages: " + b1.GetNumberPages());

            PhotoBook b2= new PhotoBook(24);
            Console.WriteLine("Second photobook pages: " + b2.GetNumberPages());

            BigPhotoBook b3= new BigPhotoBook();
            Console.WriteLine("Bigphotobook pages: " + b3.GetNumberPages());
            
            Console.Write("\n");
	    } 
    }
}

				
/**
Output : 
----------------
First photobook pages: 16
Second photobook pages: 24
Bigphotobook pages: 64
**/