#   Sistema de cadastro de alunos via terminal (Python e C#).
>Objetivo: Estudo
#    Resumo:
>O código original foi escrito em Python e reescrito em C#.
>O sistema (em ambas as linguagens) permite o cadastro de alunos com as informações: nome, nota1 (primeira nota) e nota2 (segunda nota). Assim que um aluno é cadastrado é gerado um código (RA) com base na quantidade de alunos já cadastrado e armazena o valor automaticamente. A média é calculada e armazenada automaticamente.
>O sistema também permite a consulta do aluno por nome, bem como a visualização de todos os alunos cadastrados.

#   C#:

>Conceitos abordados:
1.  Estrutura de um programa em C#
- Uso da classe Program com o método de entrada Main.
- Definição de métodos auxiliares (Cadastrar, Consultar, VisualizarTodos, Menu) para organizar o código.
2. Coleções genéricas
- Uso de List<Aluno> para armazenar objetos dinamicamente.
- Métodos importantes: Count e Add.

3. Programação orientada a objetos (POO)
- Uso da classe Aluno (mesmo não estando no código, você faz referência a ela).
- Atributos (codigo, nome, nota1, nota2).
- Métodos (CalcularMedia() e Visualizar()).
- Instanciação de objetos com new.
4. Controle de fluxo
- Estrutura de repetição while para manter o programa ativo até que o usuário escolha sair.
- Estrutura condicional switch para escolher a ação com base na opção digitada.
- Uso de break para controlar a execução do switch.
5. Entrada e saída de dados
- Console.WriteLine e Console.Write para exibir informações.
- Console.ReadLine para entrada de dados.
- Conversão de tipos (Convert.ToDouble, Convert.ToInt32).
6. Organização de código em métodos
- Separação da lógica em funções menores: cada responsabilidade está isolada (Menu, Cadastrar, Consultar, VisualizarTodos).
- Isso segue o princípio da responsabilidade única (SRP).
7. Laço com condição de parada
- Uso da variável opcao para controlar a execução do loop até que o valor 4 seja digitado.

#   Python:

>Conceitos abordados
1. Programação orientada a objetos (POO)
- Definição de uma classe (class Aluno).
- Criação de atributos (variáveis de instância): codigo, nome, nota1, nota2, media.
- Definição de métodos:
  - CalcularMedia: encapsula a lógica de cálculo da média.
  - Visualizar: imprime os dados do objeto.
- Uso de objetos com a = Aluno
2. Encapsulamento de responsabilidades
- Cada função/método tem um papel específico:
  - Cadastrar → cria um aluno e adiciona à lista.
  - Consultar → busca aluno pelo nome.
  - VisualizarTodos → lista todos os alunos.
  - Menu → exibe opções e captura a escolha.
  - Main → gerencia o fluxo principal.
Isso demonstra modularização (código dividido em blocos reutilizáveis).
3. Estruturas de dados
- Uso de listas (lista_alunos) para armazenar múltiplos objetos.
- Métodos importantes de lista:
  - append() para adicionar alunos.
  - len(lista) para calcular quantidade de elementos.
4. Estruturas de controle
- Laço while True para manter o programa rodando até o usuário decidir sair.
- match/case (Python 3.10+) para criar um menu de opções com múltiplos caminhos.
- for com range(len(lista)) para percorrer os elementos da lista.
- Condição if encontrado == False para tratar busca sem resultados.
5. Entrada e saída
- input() para ler dados do usuário.
- Conversões de tipo: float(input()) e int(input()).
- print() para exibir resultados formatados (uso de f-strings em Visualizar).
6. Boas práticas aplicadas
- Separação da lógica em funções auxiliares (não tudo dentro do Main).
- Mensagens amigáveis para interação com o usuário.
- Validação parcial na consulta (mostra mensagem quando aluno não existe).
