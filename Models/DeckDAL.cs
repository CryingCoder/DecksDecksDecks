using RestSharp;

namespace DeckofDecks.Models
{
    public class DeckDAL
    {

        public DrawCard NewDeck()
        {

            RestClient url = new RestClient($"https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1");
            RestRequest request = new RestRequest();
            var response = url.GetAsync<DrawCard>(request);
            DrawCard result = response.Result;

            return result;

        }

        public DrawCard DrawPatrol(string id, int c)
        {

            RestClient url = new RestClient($"https://deckofcardsapi.com/api/deck/{id}/draw/?count={c}");
            RestRequest request = new RestRequest();
            var response = url.GetAsync<DrawCard>(request);
            DrawCard result = response.Result;

            return result;
        }
    }
}
