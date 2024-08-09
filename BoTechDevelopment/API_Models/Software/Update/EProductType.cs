namespace BoTechDevelopment.API_Models.Software.Update
{
    /* This Enum serves not only to descripe the Type of a Software Product but also
     * it used to order the Software Update. Products which are marked as Service will be updated first, because they are used to keep the System going.
     * Other Products which are published from BoTech will be preferred. Theres is no
     * Reason for this decission in this momnent (24.07.24).
     */
    public enum EProductType
    {
        ExternalProduct, // A software which was published by somebody else
        InternalProduct, // An Internal Product like ISim
        BoTechService // An Internal Service like BoTRechClient.dll => These services must be related to the API or otherwise have an essential role in the BoTech software.
    }
}
