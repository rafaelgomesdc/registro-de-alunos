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
    a.nome = input("Nome: ")
    a.nota1 = float(input("Nota 1: "))
    a.nota2 = float(input("Nota 2: "))

    lista.Append(a)

def Consultar(lista):
    pass

def VisualizarTodos(lista):
    pass

def Menu():
    print("*MENU DE OPÇÕES*")
    print("1 - Cadastrar aluno\n2 - Consultar aluno\n3 - Visualizar todos os alunos\n4 - Encerrar execução")

    return int(input("Digite a opção desejada: "))

def Main():
    lista_alunos = []

    while True:
        match Menu():
            case 1:
                Cadastrar(lista_alunos)
            case 2:
                Consultar(lista_alunos)
            case 3:
                VisualizarTodos(lista_alunos)