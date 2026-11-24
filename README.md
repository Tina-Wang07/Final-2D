# GDIM 31 Final: 2D
## Devlogs
### Milestone 1
11.23 I finished the A/D movement and animation of player kicking, Idle, jumping and walking. And also I finished the tile map.https://docs.google.com/document/d/1SYW49XZWZWClZ_oHEewMA39_3Rs7P_EdozaBswgfE1c/edit?usp=sharing

The first problem is kick the item. At the first, I click space, the kicking animation can played. But the item were not move. So I used Debug.Log() to check the code and found that the kick object was turning on, but the collider wasn't detecting the item. So I fixed KickLeft and KickRight Box Collider 2D setting (let the collider more big and cover the player one side), and turned on Is Trigger, and used OnTriggerEnter2D() in KickAttack.cs. 
Another problem is setting the time and checklist. At first, checklist wasn't appeared, and I used List<GameObject> in GameController to saved the item that will be kicked. And I created ChecklistItem prefab, and used Instantiate() in HUD.cs to create checklist automatically. And I let Checklist, ChecklistItem prefab and timer text connected. Also, for the animator, I put walking, jumping, Idle and kicking in the map. And made line to let them connected.  

### Milestone 2
TODO.

## Playtesting Reports
### Milestone 1
#### Report 1
TODO.

#### Report 2
TODO.

### Milestone 2
#### Report 1
TODO.

#### Report 2
TODO.

## Open-Source Assets
- [Interior sprites](https://rcpstd.itch.io/interior-tileset-asset-pack-16x16)
- [Ninja cat sprites](https://opengameart.org/content/cat-fighter-sprite-sheet)
- [Food sprites](https://ghostpixxells.itch.io/pixelfood)
- [More food and item sprites](https://ipixl.itch.io/pixel-art-items-part-1)
