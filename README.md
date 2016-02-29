# Sistema para controle de Alunos

Pequeno sistema para controle de Alunos.
Contém 1 bloco de notas e 1 calculadora .
Pre-requisito para vaga de Desenvolvedor na Educasfera.

# Regras e requisitos

Deverá ser montado um programa principal que permita abrir os seguintes sub-programas a serem acessados através de algum tipo de selecionador, menu ou qualquer input que permita seleção de opções:  
1- Cadastro de Cursos - Cadastro simples de cursos, seguindo a especificação abaixo:
- Um curso pode ter várias lições
- Uma lição pode ter vários arquivos;
[Curso]
	-Id
	-Nome
	-Descrição
	-Preço
[Lição]
	-Id
	-IdCurso
	-Nome

•	Estes dados devem ser persistidos no sistema, de modo que ao encerrar o programa e ao reabri-lo os dados estejam lá; 
•	Deve ser disponibilizada uma interface para realização das operações básicas de CRUD em ambas as coleções;
•	Devem ser testados e evitados cadastros com nomes duplicados;
•	 Não deve ser possível cadastrar um arquivo sem que o mesmo tenha uma lição.
		
2- Cadastro de alunos -Cadastro simples de alunos, seguindo a especificação abaixo:
[Aluno]
	-Id
	-Nome
	-DataNascimento 

Estes dados devem ser persistidos no sistema, de modo que ao encerrar o programa e ao reabri-lo os dados estejam lá; Deve ser disponibilizada uma interface para realização das operações básicas de CRUD em ambas as coleções. Devem ser testados e evitados cadastros com nomes duplicados e não deve ser possível cadastrar um arquivo sem que o mesmo tenha uma lição.
3- Matricular aluno em curso –Deve ser possível matricular um aluno em um curso através de uma interface, deve-se montar a(s) tabelas necessárias para armazenar essa informação;

4- Relatório de Alunos Matriculados em cursos - Deve ser possível listar na tela quais alunos estão matriculados em quais cursos por ordem alfabética; ( Nome do aluno / Nome do curso)

5- Calculadora - Este deverá ser semelhante ao programa "Calc" do windows, porém bem mais 	simplificado, abrangendo apenas as quatro operações básicas;
	
6- notas - Este deverá ser semelhante ao programa "Notepad" do windows, porém bem mais 	simplificado, sem nenhuma opção adicional além de uma caixa de texto que salve o que for digitado, e seja capaz de persistir essa informação;
