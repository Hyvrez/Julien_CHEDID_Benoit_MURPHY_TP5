Julien CHEDID & Benoit MURPHY

Q1:
1. What is this code about?

This code shows items that are sold in a tavern probably in WoW. 

2. Can you clearly identify the name of all the goods stored in the Guilded Rose?

The name of all the goods stored is : 
	- +5 Dexterity Vest
	- Aged Brie
	- Elixir of the Mongoose
	- Sulfuras, Hand of Ragnaros (x2)
	- Backstage passes to a TAFKAL80ETC concert (x3)
	- Conjured Mana Cake

3. What happens when the day is over?

When the day, based on conditionss, over the atribute quality and Selling of all item are modified or unchanged.

4. What happens to cheese when the day is over?

Cheese's quality grows.


5. What happens when a concert ticket goes over its expiration day?

Its quality will be equal to 0.

6. What makes this code hard to read?

There are IF statement. 

7. Do you think the rules are clear enough so that you could rework the entire solution from scratch?

Yes for me the rules are clear enough. 


Q4:
We think that for implement new functionalities it can be interesting to override the updating function and add a new variable "state" in the object
Item. For example we can put a state Conjured to treat his quality differently. It will help to stop reffering only on the name but also 
on states too have more possibility. It can also help to make asynchronous code to handle more task at the same time.