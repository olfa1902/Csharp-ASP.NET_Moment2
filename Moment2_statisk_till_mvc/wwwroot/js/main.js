'use strict';

var movie1 = { // En literal notation skapas som objekt med 2 stycken string-properties 1 tal samt string och en funktion.
    title: "Goodfellas",
    category: "Crime",
    playtime: 148 + " minuter",
    getInformation: function () { // Funktionen getinformation skapas och returnerar inputen i de olika properties i variabeln.
        return this.title + " , " + this.category + " , " + this.playtime;
    }
};

var movie2 = new Object(); // En Constructor notation skapas med samma innehåll som movie1 döpt movie2.
movie2.title = "Terminator 2";
movie2.category = "Science Fiction";
movie2.playtime = 137 + " minuter";
movie2.getInformation = function () { // Precis som i förra varaibeln skapas getinformation med uppdrag att returnera resterande värden.
    return this.title + " , " + this.category + " , " + this.playtime;
};

var movie3 = { // Literal notation likt movie1
    title: "A Few Good Men",
    category: "Drama",
    playtime: 138 + " minuter",
    getInformation: function () {
        return this.title + " , " + this.category + " , " + this.playtime;
    }
};

var movie4 = new Object(); // Constructor notation skapas likt movie2
movie4.title = "Die Hard";
movie4.category = "Thriller";
movie4.playtime = 131 + " minuter";
movie4.getInformation = function () {
    return this.title + " , " + this.category + " , " + this.playtime;
}

// getElementById används för att ändra HTML:en där id:t är output och här läggs det returnerade värdet för alla variablers getInformation ut för att sedan visas upp på skärmen.
document.getElementById("output").innerHTML += movie1.getInformation() + "\n" + movie2.getInformation() + "\n" + movie3.getInformation() + "\n" + movie4.getInformation();
