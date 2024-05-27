<h1 align="center">
   <br> 
     <img alt="Chimpanzé pensandor com fone de ouvido" width="128px" src="https://i.pinimg.com/originals/19/b6/00/19b600f458814345a73b8ede8a4bb757.jpg"></a><br>
    <span>  Távio Rodrigues</span>
</h1>

<h2 align="center">
   <br>
    <span>Blindando Seu Código com TDD e Testes Unitários Usando .NET Core</span>
</h2>

<a href="https://www.dio.me/">
     <img align="center" width="40px" src="https://hermes.digitalinnovation.one/assets/diome/logo-minimized.png">
</a>

Repositório desenvolvido para fins didáticos, contendo o projeto final do Bootcamp Coding The Future Avanade - .NET Developer da [Digital Innovation One](https://www.dio.me/).

<h3>Descrição do Projeto Desafio Final dio dotNet Developer Avanade</h3>

<h4>Visão Geral</h4>
O projeto é uma biblioteca desenvolvida em .NET com C# que contém duas partes principais:

**DesafioDeProjetoBiblioteca**: Uma biblioteca de classes para manipulação de arquivos.
**DesafioDeProjetoTests**: Um conjunto de testes unitários para validar as funcionalidades da biblioteca, utilizando o framework xUnit.
**Estrutura do Projeto**
**DesafioDeProjeto.sln**: A solução principal que agrupa os projetos.
**DesafioDeProjetoBiblioteca**:
**FileProcess.cs**: Contém a classe FileProcess com métodos para verificar, criar, ler, escrever e deletar arquivos.
**DesafioDeProjetoTests**:
**FileProcessTests.cs**: Contém os testes unitários que cobrem todas as funcionalidades da classe FileProcess.
**Funcionalidades da Classe FileProcess**
A classe **FileProcess** oferece uma variedade de métodos para manipulação de arquivos, incluindo:

1. **FileExists(string fileName)**: Verifica se um arquivo existe.
Lança **ArgumentNullException** se **fileName** for **null** ou vazio.

2. **CreateFile(string fileName, string content)**: Cria um novo arquivo com o conteúdo especificado.
Lança **ArgumentNullException** se **fileName** for **nul**l ou vazio.

3. **ReadFile(string fileName)**: Lê o conteúdo de um arquivo existente.
Lança **ArgumentNullException** se **fileName** for **null** ou vazio.
Lança **FileNotFoundException** se o arquivo não for encontrado.

4. **WriteToFile(string fileName, string content)**: Escreve (ou sobrescreve) o conteúdo em um arquivo existente.
Lança **ArgumentNullException** se **fileName** for **null** ou vazio.
Lança **FileNotFoundException** se o arquivo não for encontrado.

5. **DeleteFile(string fileName)**: Deleta um arquivo existente.
Lança **ArgumentNullException** se **fileName** for **null** ou vazio.
Lança **FileNotFoundException** se o arquivo não for encontrado.

**Testes Unitários**

Os testes unitários foram desenvolvidos utilizando o framework xUnit para garantir a confiabilidade e a correção das funcionalidades da classe **FileProcess**. Aqui estão alguns dos principais testes:

1. **FileExists_ValidFileName_ReturnsTrue**: Verifica se **FileExists** retorna **true** para um arquivo que existe.
2. **FileExists_InvalidFileName_ReturnsFalse**: Verifica se **FileExists** retorna **false** para um arquivo que não existe.
3. **FileExists_EmptyFileName_ThrowsArgumentNullException**: Verifica se **FileExists** lança **ArgumentNullException** para um nome de arquivo vazio.
4. **FileExists_NullFileName_ThrowsArgumentNullException**: Verifica se **FileExists** lança **ArgumentNullException** para um nome de arquivo null.

Outros testes incluem verificações para os métodos **CreateFile**, **ReadFile**, **WriteToFile** e **DeleteFile**, garantindo que cada funcionalidade se comporte corretamente sob diferentes condições.


<h4>Como Executar O Projeto</h4>

`git clone <URL do Repositório>
`cd DesafioDeProjeto

<h4>Considerações Finais</h4>

Este projeto fornece uma base sólida para a manipulação de arquivos em aplicações .NET, com uma cobertura de testes abrangente para assegurar a qualidade e a confiabilidade do código. A arquitetura modular e o uso de práticas recomendadas de desenvolvimento tornam este projeto fácil de manter e expandir no futuro.
