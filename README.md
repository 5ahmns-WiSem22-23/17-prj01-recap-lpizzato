
# 17-prj01-recap-lpizzato

----------

_by Linda Pizzato_

## Description
A winter-themed recap-projekt. 
Player is a pinguin with a pink hat skiing in the snow, picking up and delivering candy canes for children for christmas. But he has to be careful, on his way collecting and dropping the candy he has to watch out for the trees!  

## Assets
- Pinguin: https://www.google.com/search?q=ski+pinguin+top+down+pixel&tbm=isch&ved=2ahUKEwj0saXN9K38AhWTwQIHHd6SDp0Q2-cCegQIABAA&oq=ski+pinguin+top+down+pixel&gs_lcp=CgNpbWcQA1DXA1i2DmD_D2gAcAB4AIABqwKIAdYHkgEFMy4yLjKYAQCgAQGqAQtnd3Mtd2l6LWltZ8ABAQ&sclient=img&ei=W3C1Y7SYA5ODi-gP3qW66Ak&bih=1000&biw=1728&client=safari#imgrc=RHjFPJAcOP8opM (background removed in PS)
- Pinguin transporting Candy Cane: made in PS using Pinguin & Candy Cane Asset
- Trees: https://www.google.com/search?q=winter+tree+pixel+art&tbm=isch&ved=2ahUKEwiQ68T-l7j8AhWNQaQEHX0zA8YQ2-cCegQIABAA&oq=winter+tree+pixel+art&gs_lcp=CgNpbWcQAzIHCAAQgAQQE1DmCFjmCGD_CWgAcAB4AIABV4gBrQGSAQEymAEAoAEBqgELZ3dzLXdpei1pbWfAAQE&sclient=img&ei=otO6Y5CSOo2DkdUP_eaMsAw&bih=1000&biw=1728&client=safari#imgrc=xTzBSp_lw1xZzM (background removed in PS)
- Fence: made by myself
- Candy Canes: https://www.google.com/search?q=christmas+pixel+art&tbm=isch&ved=2ahUKEwi1lJC31L38AhVKxgIHHfSOBJsQ2-cCegQIABAA&oq=christmas+pixel+art&gs_lcp=CgNpbWcQAzIHCAAQgAQQEzIHCAAQgAQQEzIHCAAQgAQQEzIICAAQBRAeEBMyCAgAEAUQHhATMggIABAFEB4QEzIICAAQBRAeEBMyCAgAEAUQHhATMggIABAFEB4QEzIICAAQBRAeEBM6BAgjECc6BAgAEEM6BQgAEIAEOggIABCxAxCDAToECAAQHjoGCAAQHhATOggIABAIEB4QE1Dq7wNY_44EYPSPBGgBcAB4AIABkQGIAagRkgEEMTQuOJgBAKABAaoBC2d3cy13aXotaW1nwAEB&sclient=img&ei=GrK9Y7WfG8qMi-gP9J2S2Ak&bih=1000&biw=1728&client=safari#imgrc=1FKpXbzxudF5LM

## Technical Aspects
- Player Movement made with old Unity Input System. Arrows or WASD for moving forwards/backwards and rotating left/right. 
- Pick Ups get collected by colliding and dropped by moving into the delivery area.
- Only one PickUp can be transported at a time and has to be dropped off, before the next one spawns in the area and is ready to be collected.
- Player changes Sprite when collecting a PickUp (Pinguin -> Pinguin transporting Candy Cane).
- Player slows down when colliding with an obstacle

## Develpoment platforms
MacOS 12.4, Unity 2020.3.18f1, Visual Studio 8.10.25 (build 2)
