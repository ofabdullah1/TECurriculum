<template>
  <div>
    <p>{{ message }}</p>
    <form v-on:submit.prevent="onSubmit">
      <div class="form-group">
        <label for="name">Name: </label>
        <input
          required
          type="text"
          id="name"
          name="name"
          class="form-control"
          v-model="updatedPet.name"
        />
      </div>

      <div class="form-group">
        <label for="age">Age: </label>
        <input
          type="number"
          id="age"
          name="age"
          class="form-control"
          v-model="updatedPet.age"
        />
      </div>
      <div class="form-group">
        <label for="type">Type: </label>
        <input
          required
          type="text"
          id="type"
          name="type"
          class="form-control"
          v-model="updatedPet.type"
        />
      </div>
      <div class="form-group">
        <label for="breed">Breed: </label>
        <input
          required
          type="text"
          id="breed"
          name="breed"
          class="form-control"
          v-model="updatedPet.breed"
        />
      </div>

      <div class="form-group">
        <label for="image">Image URL: </label>
        <input
          type="text"
          id="image"
          name="image"
          class="form-control"
          v-model="updatedPet.image"
        />
      </div>

      <input type="submit" class="btn btn-success" />
      <input
        type="button"
        v-on:click.prevent="resetForm"
        class="btn btn-success"
        value="Cancel"
      />
    </form>
  </div>
</template>

<script>
import petService from "@/services/PetService.js";

export default {
  name: "PetUpdate",
  data: () => {
    return {
      updatedPet: {},
      message: "",
    };
  },

  methods: {
    onSubmit() {
      petService
        .updatePet(this.updatedPet)
        .then(this.$router.push({ name: "Pets" }))
        .catch((error) => {
          if (error.response) {
            this.message =
              "Error: HTTP Response Code: " + error.response.data.status;
            this.message += "    Description: " + error.response.data.title;
          } else {
            this.message = "Network Error";
          }
        });
    },
  },

  created() {
    const petId = this.$route.params.petId;
    petService
      .getPet(petId)
      .then((response) => {
        this.updatedPet = response.data;
        console.log("reached created in PetUpdate.vue");
        console.log(this.updatedPet);
      })
      .catch((error) => {
        if (error.response) {
          this.message =
            "Error: HTTP Response Code: " + error.response.data.status;
          this.message += "    Description: " + error.response.data.title;
        } else {
          this.message = "Network Error";
        }
      });
  },
};
</script>

<style>
</style>