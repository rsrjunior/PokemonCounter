# PokemonCounter
PokemonCounter: count distinct problem

## Version 1.0: Fonte de verdade

### Versão funcional, com performance O(n).
#### Memória O(n) será um problema para datasets grandes.
#### Serve como ponto de partida para as otimizações, pois se trata de um cálculo de cardinalidade exata.
#### O resultado do processamento aqui pode ser considerado como verdade absoluta para testes com as futuras otimizações.

## v1.1 Take a shortcut with RegEX

### Foram incluidas RegEX par tratar os casos
#### sempre N, S, E ou E;
#### Zig-Zag obrigatório ex. (N+E+S+E)+

## Resultados atuais, na tag v1.1
### Arquivo O25165825.txt
#### 25.165.825 Pokemons
#### v1.0 Pico de Memoria: 2.5G, Tempo: 70s.
#### v1.1 Pico de Memoria: 50M, Tempo: 6s.
### Arquivo DRUNK_SOUTH_18869761.txt
#### 18.869.761 Pokemons
#### v1.0 Pico de Memoria: 1.6G, Tempo: 45s.
#### v1.1 Pico de Memoria: 150M, Tempo: 12s.

## Instruções
### dotnet core 3.1
### dotnet build e dotnet run [arquivo] para o projeto PokemonCounterApp
### dotnet test para o projeto PokemonCounterTests
### arquivos de teste na pasta PokemonCounterTests/assets


