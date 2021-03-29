

SELECT Owner.Id, Email, Owner.[Name], Address, NeighborhoodId, Phone, Neighborhood.Name
                        FROM Owner
                        Left Join Neighborhood on Owner.NeighborhoodId = Neighborhood.Id;
                    