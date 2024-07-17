# Hello World!

With a over a 100% increase in performance for ‘Nederlands’ compared to QWERTY.
I would like to present the “Reduced Typing Method” or RTM-layout:

## Main layer
![Main](/images/1_main.png)

## Numpad layer
 
## Index and middle finger combos
 ![Index and Middle](/images/2_combo_index_ring.png)
 ![Index and Middle](/images/2_combo_index_ring_diag.png)
 
## Middle and ring finger combos plus index finger chords
 ![Middle and Ring](/images/3_combo_middle_ring.png)

## Index, middle and ring finger combos
 
## Chords
 
## Developer specific combos

## Load
This is the character frequency load for each finger:
 
# Design principles

While English was taken into consideration, this layout is specifically designed for the Dutch language and based on the extensive OpenTaal dataset and years of my WhatPulse typing data.  
It is designed with several personal constraints and philosophies in mind.  
Please note that not all where defined from the start added while testing out concepts and doing research.  
I did not intend to end up with a low key count layout.  
My goal is not to create the fastest layout but the most comfortable layout.  
The design principles are mostly applicable to other languages though and that’s why I’m publishing this in English instead of Dutch.  

# About me
I’m a full stack web developer using languages like C# and Typescript with about 25 years of experience.  
I have several RSI issues that I’ve reduced or resolved by changing how I work behind a desk.  
A custom key layout is part of that.

# Journey
Previously fluent in Colemak (before the DH mod) and trying Workman for a long period I could not get my pinkies to hurt less.  
Also I felt that the layouts could never perform great for languages they weren’t designed for.  
After receiving my Ergodox EZ I went down the rabbit hole of designing a custom layout.  
With the help of Ian this resulted in eNNe which I use to this day. 

After receiving my Glove 80 I wanted to update the layout to better accommodate the characteristics of the keyboard.  
KLA, now maintained by Ian, received several mayor improvements since the last time I used it and I noticed that eNNe wasn’t doing so great anymore.  
In this journey I discovered the new concept of combo’s.  
And after a few experiments and grasping their power, I am now convinced that they are superior to the usage of layers.  
Mentally the layers where always confusing and could never find the symbol I needed.

# Dataset
Before starting the redesign I first wanted a better dataset.  
The subtitle scrapings used in the design of eNNe where in my opinion not the best option anymore.  
After doing some research I discovered the OpenTaal wordlist dataset.  
Specifically [wordlist v.2.20.19 elements/basiswoorden-gekeurd](https://github.com/OpenTaal/opentaal-wordlist/blob/master/elements/basiswoorden-gekeurd.txt)  
Sadly this dataset does not contain a frequency so I augmented it with the 50k NL FrequencyWords dataset. 
Using a very simple console app I generated a 5MB randomized dataset: [opentaal_2.20.19_randomized.txt](/resources/opentaal_2.20.19_randomized.txt) to add enters, dots, comas and question/exclamations marks.
It was the best dataset I could publicly find that would punish any bad decisions regarding bigram and trigrams.
With the dataset ready I benchmarked several of the current top layouts which gave me even more confidence to start the design process. 

# Fingers
The Thumb is very strong but was never intended to do sideways moment, it is also not very nimble. 
I am also looking holistically to the finger usage and the right thumb is used a lot while handling a smart phone. 
It is also used for mouse movement (or in my case pen movement).
For me personally the thumb already feels sore with periods of high smartphone usage. 
Several tests for using a high frequency letter like T or E resulted in pains in that thumb at the end of the day. 
So I placed a design restriction on the right thumb that the combined usage must not be higher than 1% of the total.

The Index finger is very nimble and strong; the lateral movement is no real problem. 
Diagonal key movements are in my opinion uncomfortable. 
Different to the Engram Layout I chose not use the diagonal keys at all and place a low frequency on the lateral key. 
These keys can handle a high movement load. 
A tiny note: the effort for the key above the home row is a little higher than the key below because the finger needs to completely stretch

The Middle finger is very strong and vertical movement is easy. 
So these fingers can handle a good load but moving around is a little slower.

The Ring finger is almost the same as the same as the middle; just a little less strong and nimble.  
The key below the homerow is a little harder to reach.

Pinkies are weak and not very nimble.  
Can do one key very well but other keys require a lot of effort or are uncomfortable.  
I therefor opted to exclude the keys below and above the pinky homerow and any keys to the sides.

That leaves this heatmap for me personally on the Glove 80
![Glove 80 Heatmap](/images/glove80_heatmap.png)
This ended up in a hamburger looking key availability. 

# Movement cluster
In all my research in all these years I cant point to a single layout who thinks of the movement cluster a first class citizen. 
They are not considered when placing the keys an almost always moved to a layer. I never understood this. 
The arrow keys combined account for 12,74% of my usage. Adding home, end and page up/down adds another 4,81%. Combined that’s 17,55% or nearly one 5th of all keypresses. To add more - in my personal observations - I see the usage is frequently between other operations. For instance moving the cursor two rows up on this line to change that line with some new letters. 
Therefore they must be a first class citizen. But how they are designed; in a row or in a cluster; is up to preference.
Using combos the home/end keys can be placed on the positions of the arrow cluster and therefor require no extra movement to use them.

# Combos have a better mental model
When I first discovered the principles of layers I was in awe of their potential power. 
Envisioning a highly used shortcut behind a homerow key for instance was something I’d never even dreamed of. 
But after years of using them I still feel confused for where a key is located. 
I still can’t find the ‘~’ key and always have to try several layers and keys. 
This might be something other people don’t struggle with but I bet I’m the only one. 
Layers require you to enter a mental modal for that layer

Combos on the other hand don’t have this problem because the mental modal is different.
Pressing two (or more) keys at the same time is just as pressing one key. 
It’s a muscle memory you can learn and requires no mental model for where a key or macro is positioned in the layer stack. 
It does require more effort and coordination obviously but in my opinion less so than using layers.
While combo’s can be created for two hands, pressing both index homerow keys for instance. 
I opted not to use that because that would add a bit of mental load and coordination; though in my opinion still better than layers. 

They also allow access when in another layer! 
For instance mathematical symbols can be used on the same keys as the numpad layer but are also available on the base layer.

Chording keys (pressing two keys with one finger) is also an option on the Glove with its lightweight choc switches, but I opted to only use that for lower frequency combo’s.

# Auto shifting
The layout is designed for the usage of auto shift where holding a key sends the shifted version for that key. 
I prefer this to the usage of homerow mods. It radically reduces the need for the shift key. 
And my most used shortcuts are just a combo or single key press away.

# Hand usage
I’m right handed so my mouse handling is on the right. I chose the right side for the vowels and left side for the consonants. 
So that holistically the load is more balanced.

# Dutch - IJ bigram
A combination of I and J it is basically the same as the Y in English. It is treated as a vowel in the language for example; jij mijn dijk rijk. But it requires the pressing of two keys. 
In the OpenTaal dataset the 13% of all I and J presses are for IJ; 10% only for pressing the J and 83% for the I. I opted to add IJ as a key to the layout. 

# Dutch - I
Double vowels are very common, for instance: maan, groot, vuur en veer. For the I they are virtually non-existent. For any pinky vowel the I is therefore the most logical choice based on that metric. It also being reduced in usage by adding the IJ-key adds more 

# Dutch – SCH
The trigram SCH is used frequently in Dutch. Because of the placement of H next to the S in the layout, a chord between the keys allows for SCH to be sent. This would save two keypresses. 

# WhatPulse data set
My WhatPulse data set, now double the size it was, was used as a decision guide. 
Though not 100% accurate with the dataset all choices could be made within the margins.

Resulting in these finger loads:  
![Glove 80 Heatmap](/images/finger_usage.png)

And this key load:  
![Glove 80 Heatmap](/images/key_usage.png)


# KLA
Sadly KLA doesn’t recognize the IJ character and so does not take this in consideration.
It also has no support for combo’s. So I used the AltGr key for the combo keys. My thinking is that it’s still pressing two keys. Using the combo’s as I intended should actually make it even more efficient then measured by KLA, by my reasoning.

# Numpad
I currently use a normal numpad layout:
789  
456  
123  
0  
But I redesigned it to be logical and allow for the combo’s on both sides to be used. 
Odds on the left and Evens on the right. That way it can be used from the homerow. 
I know there are layouts that are statistically better, but are less memorable.

# Future
After putting the finishing touches I wanted to put this out in the wild as soon as possible. 
I plan to publish better images, the dataset, my WhatPulse dataset, .json files and more as soon as possible but will require some more work.
I was just too excited to wait!

# Influences and honorable mentions
Ian Doug (and X1)  
Shenafu (and BEAKL)  
Jonas Hietala (and T-34 keyboard layout and The Vergecast for pointing me to it)  
Glove80 community  
Reddit community  
Arno Klein (and the Engram)  
Moosy Research  
Ben Vellack
