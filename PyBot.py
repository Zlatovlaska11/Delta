import discord
from dotenv import load_dotenv
import random
import python_weather


load_dotenv()
TOKEN = "MTAyOTgwNDQzOTEwNTY5OTg5MA.GbHX2K.JQ5l-6_zw0-NWvy5ScVMn2cCIww1usvQ7P_D4E"

client = discord.Client(intents = discord.Intents.all())

block_words = ["shit", "fuck", "bitch", "nigga"]

games = ["Minecraft", "CSGO", "Fortnite", "Valorant", "league of legends", "COD","rainbow six siege"]



########### EVENTS ###############

@client.event
async def on_ready():
    print(f'{client.user} has connected to Discord!')
    


                
            
@client.event
async def on_message(msg):
    if msg.author != client.user:
        if msg.content.startswith("$hi"):
            await msg.channel.send(f"Hi {msg.author.display_name}")
            
    
    
    if msg.author != client.user:
        if msg.content.lower().startswith("$game"):
            await msg.channel.send(f"Well let´s play " + random.choice(games))
   
            
    for text in block_words:
            if "Moderator" not in str(msg.author.roles) and text in str(msg.content.lower()):
                await msg.delete() 
                return 
            
            
    
    
            
            
    
            
    
            
    
           
                 
               
             
@client.event
async def on_member_join(member):
    await member.create_dm()
    await member.dm_channel.send(
        f'Hi {member.name}, welcome to my Discord server!'
    )
    
    

    



                       
client.run(TOKEN)


            