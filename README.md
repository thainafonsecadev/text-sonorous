
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
![Api](https://github.com/user-attachments/assets/97cabd05-bf15-4884-aaac-dfe98ffc4a20)


# Exemplo retorno 
return BadRequest("O texto precisa ser preenchido");
aqui o BadRequest foi utilizado no método " Try Catch "

# Resposta do erro quando o texto não esta preenchido 
![ApiErro](https://github.com/user-attachments/assets/e94cab72-bef5-457b-acde-ca53ec3aed1f)

