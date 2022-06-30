namespace TheTourGuyTest.Core.DTOs.Requests
{
    public class CreatePersonResponse
    {
        public int PersonId { get; set; }

        public CreatePersonResponse()
        {

        }

        public CreatePersonResponse(int personId)
        {
            PersonId = personId;
        }
    }
}
