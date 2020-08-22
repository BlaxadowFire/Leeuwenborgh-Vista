from RiotAPI import RiotAPI

def main():
    api = RiotAPI('RGAPI-5f74277e-2c41-4705-9b0a-a494b2bd6660')
    r = api.get_summoner_by_name('BlaxadowFire')
    print(r)

if __name__ == "__main__":
    main()
