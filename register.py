class Aluno:
    codigo = 0
    nome = ""
    nota1 = 0.0
    nota2 = 0.0
    media = 0.0

    def CalcularMedia(self):
        self.media = (self.nota1 + self.nota2) / 2

    def Visualizar(self):
        print(f"Aluno: {self.codigo}\nNome: {self.nome}\nNota 1: {self.nota1}\nNota 2: {self.nota2}\nMédia: {self.media}")

def Cadastrar(lista):
    a = Aluno()
    a.codigo = len(lista) + 1
    a.nome = input("\nNome: ")
    a.nota1 = float(input("Nota 1: "))
    a.nota2 = float(input("Nota 2: "))
    a.CalcularMedia()

    lista.append(a)

def Consultar(lista):
    print("CONSULTAR ALUNO POR NOME\n")
    nome = input("Digite o nome: ")
    encontrado = False
    print()

    for i in range(len(lista)):
        if lista[i].nome == nome:
            lista[i].Visualizar()
            encontrado = True

    if encontrado == False:
        print("Aluno não encontrado.")

def VisualizarTodos(lista):
    for i in range(len(lista)):
        print()
        lista[i].Visualizar()

def Menu():
    print("*MENU DE OPÇÕES*")
    print("\n1 - Cadastrar aluno\n2 - Consultar aluno\n3 - Visualizar todos os alunos\n4 - Encerrar execução\n")

    return int(input("Digite a opção desejada: "))

def Main():
    lista_alunos = []

    while True:
        print()
        match Menu():
            case 1:
                Cadastrar(lista_alunos)
            case 2:
                Consultar(lista_alunos)
            case 3:
                VisualizarTodos(lista_alunos)
            case 4:
                break

Main()

print("\nFim da execução.")