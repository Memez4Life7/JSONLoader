using System.Collections.Generic;

namespace JLPlugin.Data
{
    [System.Serializable]
    public class condition
    {
      public string slotIsEmpty;
    	public string slotIsOcuppied   
	    public List<string> cardNameContains   
	    public List<string> cardAbilities   
	    public List<string> cardTraits   
	    public List<string> cardSpecialAbilities   
	    public string cardHealthHigherThan   
	    public string cardHealthLowerThan   
	    public string cardAttackHigherThan   
	    public string cardAttackLowerThan   
	    public List<string> cardCost   
	    public List<string> cardTribe   
	    public string cardRarity
    }
}
