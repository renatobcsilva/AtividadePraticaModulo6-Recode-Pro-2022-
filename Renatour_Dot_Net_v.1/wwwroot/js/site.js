// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function mensagem() {

	nome = document.getElementById("formGroupExampleInput").value

	document.getElementById("formGroupExampleInput").value = ""
	document.getElementById("formGroupExampleInput2").value = ""
	document.getElementById("exampleFormControlInput1").value = ""
	document.getElementById("exampleFormControlTextarea1").value = ""
	alert(`${nome}, sua mensagem foi enviada!`)
}