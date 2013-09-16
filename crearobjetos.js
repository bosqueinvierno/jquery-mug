var Persona = function(){
};
Persona.prototype.nombre = "juan";
Persona.prototype.apellido = "perez";
Persona.prototype.saludar = function(){
	return "hola, mi nombre es: " 
	+ this.nombre +  ", " + this.apellido;
};

var juan = new Persona();
console.log(juan.saludar());

var jose = new Persona();
jose.nombre = "jose";
console.log(jose.saludar());
