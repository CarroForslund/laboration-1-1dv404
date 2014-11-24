"use strict";

window.onload = function(){
	
	var count = 0;
	var maxNumber;
	var secondMaxNumber;
	var value = 10; //Antal nummer att skriva in
	
	var convertString = function(number){

		if (!isNaN(number)){
			number = parseInt(number); //Gör så att numret räknas som heltal och räknar bort om det står 0 i början
			count+=1;
			if (count <= value){
				if (count === 1){
					maxNumber = number;
					console.log("Inmatat nummer: " +maxNumber);
				}
				else {
					if (maxNumber < number){
						secondMaxNumber = maxNumber;
						maxNumber = number;
					}
				}
				return "Du har skrivit in " +count+ " tal och ska skriva in " +(value-count)+ " tal till.";
			}
				console.log(secondMaxNumber);
				return "Det näst högsta talet av de du matade in är: " +secondMaxNumber;
		}
		else {
			throw new Error ("Du måste skriva in siffror.");
		}
	};

	// ------------------------------------------------------------------------------


	// Kod för att hantera utskrift och inmatning. Denna ska du inte behöva förändra
	var p = document.querySelector("#value"); // Referens till DOM-noden med id="#value"
	var input = document.querySelector("#string");
	var submit = document.querySelector("#send");
	var result = document.querySelector("#result");

	// Vi kopplar en eventhanterare till formulärets skickaknapp som kör en anonym funktion.
	submit.addEventListener("click", function(e){
		e.preventDefault(); // Hindra formuläret från att skickas till servern. Vi hanterar allt på klienten.

		p.classList.remove( "error");

		try {
			var answer = convertString(input.value); // Läser in texten från textrutan och skickar till funktionen "convertString"
			p.innerHTML = answer;		// Skriver ut texten från arrayen som skapats i funktionen.	
		} catch (error){
			p.classList.add( "error"); // Växla CSS-klass, IE10+
			p.innerHTML = error.message;
		}
	
	});
	
	result.addEventListener("click", function(e){
		e.preventDefault(); // Hindra formuläret från att skickas till servern. Vi hanterar allt på klienten.
		console.log(secondMaxNumber);
		var showResult = "Det näst högsta talet av de du matade in är: " +secondMaxNumber;
		p.innerHTML = showResult;
	
	});



};