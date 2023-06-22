
using book;

var newBook1 = new FictionBook("13 km from the tunnel", "Ruben Yesayan", 2023, "Armenian", 4800, "AMD");
var newBook2 = new FictionBook("Blood stone", "Irna Van Zyl", 2023, "Armenian", 5990, "AMD");
var newBook3 = new ScientificBook("A brief history of the future", "Yuval Noy Harari", 2020, "Armenian", 5800, "AMD", 504);
var newBook4 = new ScientificBook("Theory of literature", "Austin Warren", 2008, "Armenian", 2500, "AMD", 514);

newBook1.Print();
newBook2.Print();
newBook3.Print();
newBook4.Print();