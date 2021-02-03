App# GeradorDeCurriculo (C# em .net core)

#Backstory

No momento eu trabalho como instrutor de informática em uma escola de cursos livres chamada Micro Center em Porto Ferreira-SP,
e nessa escola também oferece-se serviços de foto cópia e digitações diversas, incluindo digitação de currículos. Apesar desse
não ser meu trabalho, sempre acaba sobrando pra mim ter que fazer coisas corriqueiras como digitar curriculos quando o atendimento 
está lotado.
E visando a facilitação dessa tarefa para que não atrapalhe o meu trabalho de instruir os alunos, eu decidi criar essa aplicação
que proporciona uma interface gráfica para o preenchimento de curriculos no modelo padrão da escola. Dessa forma eu consigo
preencher e percorrer os campos com uso da tecla TAB, e salvar na pasta do atendente que pediu ajuda, direto pela aplicação.

#Sobre a aplicação

A aplicação está sendo construida com C# em .net core de forma bem simples, usando Aspose.word que é uma API para processamento
de documentos Word.
A aplicação abre um documento modelo criado em word com campos do tipo MERGEFIELD, e através de métodos da API faz a troca 
desses campos pelos dados dos formulários da aplicação e por fim executa um trim nos campos que tenham ficado vazios.
Os formulários da aplicação são baseados em campos comuns de um curriculo distribuidos em abas como "Informações Pessoais",
"Escolaridade" e "Experiências Profissionais".

