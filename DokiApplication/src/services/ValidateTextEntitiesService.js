export default {
  name: "ValidateTextEntitiesService",
  functional: true,

  validate: function(textEntities = []) {
    let validatedEntities = [];
    textEntities.forEach(function(entity) {
      let currentValidated = [];
      validatedEntities.forEach(validEntity => {
        //right 
        if (entity.position > validEntity.position 
          && entity.position + entity.length > validEntity.position + validEntity.length) {
            let newEntity = {type: entity.type, position: entity.position, length: validEntity.length - entity.position};
            entity.length -= newEntity.length;
            entity.position += newEntity.length;
            currentValidated.push(newEntity);
          }
        //left
        if (entity.position < validEntity.position
          && entity.position + entity.length < validEntity.position + validEntity.length) {
            let newEntity = {type: entity.type, position: validEntity.position, length: (validEntity.position + validEntity.length) - (entity.position + entity.length)};
            entity.length -= newEntity.length;
            currentValidated.push(newEntity);
          }
      });
      validatedEntities.concat(currentValidated);
    });
    return validatedEntities;
  }
};
