
# TextSonorous - IBM Text to Speech API

Transforme texto em voz com uma API simples, rápida e integrada ao serviço *Text to Speech da IBM Cloud*.  
Desenvolvido em .NET 6, este projeto oferece uma interface REST para gerar áudios em MP3 a partir de entradas textuais.

---

# Tecnologias Utilizadas

	.NET 6
	C#
	ASP.NET Core Web API*
	IBM Watson Text to Speech SDK
	Postman (para testes)

---

# Exemplo utilizado para retorno

{

	"tex" : " mensagem sugerida "
	" voice" : " ex: " pt-BR_V3Voice"
}

# retorno 200 ok
![Api](https://github.com/user-attachments/assets/bf65c46b-de4a-4764-9b99-2d85aa7650aa)

# Exemplo retorno 
return BadRequest("O texto precisa ser preenchido");
aqui o BadRequest foi utilizado no método " Try Catch "

# Resposta do erro quando o texto não esta preenchido 
![ApiErro](https://github.com/user-attachments/assets/bc4ea8f1-6d01-46a3-90a0-b5d28eb23bdb)
