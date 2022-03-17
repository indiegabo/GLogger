<p align="right">
  Read in <a href="https://github.com/indiegabo/GLogger">English</a>
</p>

# GLogger - Um logger útil para Unity

Esse pacote te permite adicionar um objeto na sua hierarquia que irá conduzir as mensagens de log do seu projeto. Com ele você poderá ligar e desligar as mensagens, assim como escolher suas cores.

## Video explicativo

Se liga no vídeo que fiz para o YouTube para ensinar como usar:

[![IMAGE ALT TEXT HERE](https://i.ibb.co/HttVn5Q/thumbnail.png)](https://www.youtube.com/watch?v=UGMKJ--jRqQ)

## Instalando

1. Abra o package manager
2. Clique no botão "mais" e depois em "Add package from git URL"
3. Cole https://github.com/indiegabo/GLogger.git e clique em "add"
4. Aguarde o package manager instalar e pronto!

## Como usar

1. Clique com o botão direito na sua hierarquia e escolha GLogger -> GLog
2. Escolha as cores das mensagens
3. Log uma mensagem usando código!

##### Ligando e Desligando

Usando o parâmetro "Should Log" no editor, você pode ligar e desligar as mensagens. Não precisa se preocupar em remover a mensagem do código.

## Logando as mensages

##### Mensagem padrão

```csharp
GLog.I?.Log("Uma mensagem menos blé. Mas blé do mesmo jeito.");
```

##### Mensagem de Sucesso

```csharp
GLog.I?.Success("Aeeeee! Funfou essa bagaça!");
```

##### Alerta

```csharp
GLog.I?.Warning("Cuidado ae viu? Tá dando ruim");
```

##### Perigo

```csharp
GLog.I?.Danger("É, deu ruim! =/");
```

## Snippets

Me deixa te fornecer algumas snippets para você usar no seu editor e facilitar sua vida quando estiver codificando.

##### Para VSCode

```json
{
  "GLog": {
    "scope": "csharp",
    "prefix": ["glog", "log"],
    "body": ["GLog.I?.Log(\\$\"\");"],
    "description": "A default GLog message"
  },
  "Success GLog": {
    "scope": "csharp",
    "prefix": ["success", "log"],
    "body": ["GLog.I?.Success(\\$\"\");"],
    "description": "A success GLog message"
  },
  "Warning GLog": {
    "scope": "csharp",
    "prefix": ["warning", "log"],
    "body": ["GLog.I?.Warning(\\$\"\");"],
    "description": "A warning GLog message"
  },
  "Danger GLog": {
    "scope": "csharp",
    "prefix": ["danger", "log"],
    "body": ["GLog.I?.Danger(\\$\"\");"],
    "description": "A danger GLog message"
  }
}
```

##### Outros editores / IDEs

No momento eu não conheço a forma de outros editores e IDEs lidar com snippets. Se você puder me ajudar mandando algumas para eu melhorar esse documento, vou ficar muito muito feliz!

## Onde me achar

https://indiegabo.com

## Agradecimentos e Referências

Muito obrigado a [GabrielBigardi](https://github.com/GabrielBigardi) e [RicardoQLG](https://github.com/RicardoQLG) que criaram pacotes que eu modelei para estudar e aprender como fazer os meus.
