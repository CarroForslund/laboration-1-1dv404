"use strict";

window.onload = function(){
	
	var convertString = function(str){
		
		if (isNaN(str)){
			var newStr = "";
			var count_a = 0;
			var count_A = 0;
			
			for (var i = 0; i < str.length; i++){
				
				if (str[i] == "A"){
					count_A += 1;
				}
				else if (str[i] == "a"){
					count_a += 1;
				}
				
			}
			return "Antal A: " +count_A+ "<br />Antal a: " +count_a;
		}
		else {
			throw new Error ("Du måste skriva in något och du kan inte skriva enbart siffror.");
		}
	};
	// ------------------------------------------------------------------------------


	// Kod för att hantera utskrift och inmatning. Denna ska du inte behöva förändra
	var p = document.querySelector("#value"); // Referens till DOM-noden med id="#value"
	var input = document.querySelector("#string");
	var submit = document.querySelector("#send");

	// Vi kopplar en eventhanterare till formulärets skickaknapp som kör en anonym funktion.
	submit.addEventListener("click", function(e){
		e.preventDefault(); // Hindra formuläret från att skickas till servern. Vi hanterar allt på klienten.

		p.classList.remove( "error");

		try {
			var answer = convertString(input.value) // Läser in texten från textrutan och skickar till funktionen "convertString"
			p.innerHTML = answer;		// Skriver ut texten från arrayen som skapats i funktionen.	
		} catch (error){
			p.classList.add( "error"); // Växla CSS-klass, IE10+
			p.innerHTML = error.message;
		}
	
	});



};