# Jokenpô — v0.2.0 🎮✂️📄🪨

Primeira versão publicada do projeto **Jokenpô**, um sistema de torneio de Pedra-Papel-Tesoura desenvolvido em C#/.NET.

Esta é uma versão inicial, focada em validar a lógica do torneio via console. Ainda não há interface gráfica ou web — o objetivo deste marco é ter o "motor" do jogo funcionando de ponta a ponta.

## ✅ Funcionalidades desta versão

- Execução via **linha de comando (console)**.
- Solicita ao usuário a **quantidade de jogadores** que participarão do torneio.
- Executa o torneio e define um vencedor.
- Exibe o campeão ao final, identificado como **"Jogador N"** (N = número do jogador).
- Faz a sequência com pausas de 2 segundos para visualizar melhor as partidas acontecendo.

## 🔜 O que ainda não está incluído

Para deixar claro o escopo deste primeiro momento:

- Sem interface gráfica ou front-end (somente CLI).
- Sem nomes personalizados para os jogadores (identificação apenas por número).
- Sem persistência de dados (histórico de torneios, placares, etc.).
- Sem API REST — o projeto ainda roda localmente como aplicação de console.

Essas funcionalidades fazem parte do roadmap do projeto e serão endereçadas em versões futuras, conforme a evolução das fases:

1. ✅ Lógica de torneio via console (esta versão)
2. Refatoração com Orientação a Objetos
3. Exposição como API REST
4. Front-end em React
5. Containerização e deploy

## 💻 Como executar

Este release inclui builds para diferentes ambientes:

### Windows (recomendado — não requer .NET instalado)

Build *self-contained*, já inclui o runtime do .NET:

1. Baixe e extraia a pasta `net10.0/win-x64/publish/`.
2. Execute `Jokenpo.exe`.

### Windows / Linux (requer .NET 10 Runtime instalado)

Build *framework-dependent*, menor em tamanho, mas exige o [.NET 10 Runtime](https://dotnet.microsoft.com/download) instalado na máquina:

1. Baixe a pasta `net10.0/publish/`.
2. Execute:
   - Linux: `./Jokenpo`
   - Windows: `dotnet Jokenpo.dll`

### Requisitos

| Build | Requisito |
|---|---|
| `win-x64/publish` | Nenhum (self-contained) |
| `net10.0/publish` | .NET 10.0 Runtime instalado |

## 📌 Observações

Esta é uma versão de desenvolvimento (v0.2.0), destinada a documentar o progresso do projeto e servir de base para as próximas iterações. Feedbacks e sugestões são bem-vindos via Issues do repositório.
