# HW4
## Devlog
The PlayerController class defines the view side of this pattern, where it triggers three events: PointsEarned, GameOver, and PlayerFlapped. The GameController and CanvasController class defines the control side of the code by playing sounds or updating UI. GameController handles sound outputs that correlate to each of these events, and the CanvasController class handles PointsEarned and GameOver events by updating the score text and setting active the "Game Over" text respectively. Locator.cs made the player object linked by PlayerController a singleton to ensure that it's the only object on field triggering the three events and causing them to be invoked in GameController and CanvasController.

[Itch.io link](https://hayaya22333.itch.io/mg-4)
## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites
- [Industrial Pipe Platformer Tileset](https://wwolf-w.itch.io/industrial-pipe-platformer-tileset) - tube sprites
