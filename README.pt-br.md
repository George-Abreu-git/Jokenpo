# 🪨📄✂️ Jokenpô — Campeonato em C#

Projeto de jogo de Jokenpô desenvolvido em **C# com .NET 10**, utilizado como projeto de aprendizado de lógica de programação, orientação a objetos e evolução full-stack.

> 🌐 English version: [README.md](./README.md)

---


## 📦 Última Release

**Versão Atual:** **v0.1.0**

A primeira versão pública entrega o motor inicial do torneio como uma aplicação de console desenvolvida em .NET.

### Destaques da Release

- 🎮 Campeonato completo de Pedra, Papel e Tesoura
- 👥 Quantidade de jogadores definida pelo usuário
- 🏆 Progressão automática do torneio até restar apenas um campeão
- 💻 Aplicação de console desenvolvida em C# e .NET
- 🚀 Primeira versão oficial publicada do projeto

Esta versão tem como objetivo validar toda a lógica principal do jogo. Recursos como API REST, interface em React, persistência de dados e deploy em nuvem fazem parte das próximas etapas do roadmap.

📄 Para consultar todas as informações da versão, acesse:

- [`Jokenpo/RELEASE_v0.1.0.md`](./Jokenpo/RELEASE_v0.1.0.pt-br.md)

---

## 🗺️ Roadmap do Projeto

```
Jokenpô
│
├── ✅ Fase 1 — Lógica Pura (Console)
│   ├── ✅ Input e criação de jogadores
│   ├── ✅ Validação de quantidade de jogadores
│   ├── ✅ Geração de nicks automáticos
│   ├── ✅ Separação em duplas
│   ├── ✅ Validação de jogadas e jogada aleatória
│   ├── ✅ Enum de jogadas (Pedra, Papel, Tesoura)
│   ├── ✅ Lógica do campeonato (em desenvolvimento)
│   ├── ⏳ Estrutura de campeonato com Bye
│   ├── ✅ Partidas entre duplas
│   ├── ⏳ Lista de vencedores e perdedores
│   ├── ✅ Quantidade de rodadas definida pelo usuário
│   ├── ✅ Sistema de campeonato até 1 vencedor
│   └── ⏳ Personalização do menu
│
├── ⏳ Fase 2 — Orientação a Objetos (POO)
│   └── Refatoração completa com classes, herança e encapsulamento
│
├── ⏳ Fase 3 — Back-end API
│   └── Transformar a lógica do jogo em uma API REST com ASP.NET
│
├── ⏳ Fase 4 — Front-end
│   └── Interface web separada consumindo a API
│
├── ⏳ Fase 5 — DevOps
│   └── Containerização com Docker e deploy em nuvem
│
└── ⏳ Fase 6 — Projeto Integrador
    └── Usar como projeto de integração da faculdade
```

> **Legenda:** ✅ Concluído · 🔄 Em desenvolvimento · ⏳ Planejado

---

## ✅ O que foi desenvolvido

- **Input de jogadores** — recebe a quantidade de participantes via console
- **Criação de nicks automáticos** — gera identificadores no padrão `Jogador 1`, `Jogador 2`, etc.
- **Validação de quantidade** — garante um número válido de jogadores para o campeonato
- **Separação em duplas** — embaralha e organiza os jogadores em pares para as partidas
- **Validação de jogadas** — verifica se a jogada informada é válida
- **Jogada aleatória** — gera automaticamente a jogada do computador ou de ausentes
- **Enum de jogadas** — representa as opções `Pedra`, `Papel` e `Tesoura` de forma tipada
- **Lógica do campeonato** — estrutura principal do loop do jogo *(em desenvolvimento)*
- **Partidas entre duplas** — execução das rodadas entre os pares gerados
- **Sistema de campeonato completo** — eliminar jogadores até restar 1 único vencedor
- **Quantidade de rodadas** — permitir que o usuário defina o número de rodadas por partida

---

## ⏳ O que falta desenvolver

- **Estrutura de Bye** — tratamento para quando o número de jogadores é ímpar
- **Lista de vencedores e perdedores** — controle e exibição do placar por rodada
- **Personalização do menu** — melhorar a interface do console com opções mais claras

---

## 🚀 Planos Futuros

| Fase | Descrição |
|------|-----------|
| 🎯 **POO** | Refatorar o projeto aplicando os pilares de orientação a objetos |
| 🌐 **API REST** | Transformar a lógica em uma API com ASP.NET Core |
| 💻 **Front-end** | Criar uma interface web separada para consumir a API |
| 🐳 **DevOps** | Containerizar com Docker e realizar deploy em nuvem |
| 🎓 **Faculdade** | Utilizar como projeto integrador de ADS |

---

## 🛠️ Tecnologias Utilizadas

- **C#** — Linguagem principal
- **.NET 10** — Plataforma de desenvolvimento
- **Console App** — Interface atual do projeto

---

## 📁 Estrutura do Projeto

```
Jokenpo/
├── Models/                 # Classes de domínio da aplicação
│   ├── GameMenu.cs         # Menu principal do jogo
│   ├── GetPlayers.cs       # Cadastro/obtenção dos jogadores
│   ├── PairsDraw.cs        # Sorteio dos confrontos (pares)
│   ├── Play.cs             # Lógica de execução das partidas
│   └── Tournament.cs       # Lógica do torneio (rodadas, bye, etc.)
├── Jokenpo.csproj          # Arquivo de configuração do projeto (.NET)
├── Program.cs              # Ponto de entrada da aplicação
├── Jokenpo.slnx            # Solution file
├── .gitattributes          # Configurações de atributos do Git
├── .gitignore               # Arquivos/pastas ignorados pelo Git
├── README.md                # Documentação (inglês)
└── README.pt-br.md          # Documentação (português)
```

---

## ▶️ Como Executar

```bash
# Clone o repositório
git clone https://github.com/George-Abreu-git/Jokenpo.git
cd Jokenpo

# Execute o projeto
dotnet run --project Jokenpo
```

> **Requisito:** .NET 10 SDK instalado

---

## 👤 Autor

**George Abreu**
[![GitHub](https://img.shields.io/badge/GitHub-George--Abreu--git-181717?style=flat&logo=github)](https://github.com/George-Abreu-git)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-Conectar-0077B5?style=flat&logo=linkedin)](https://linkedin.com/in/george-abreu-siqueira)
s