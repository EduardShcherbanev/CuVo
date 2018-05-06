import { GET_VOCABULARY_SUCCESS, GET_VOCABULARY_ERROR } from './vocabularyConstants.jsx'
import "isomorphic-fetch"

export function receiveVocabulary(data) {
    return {
        type: GET_VOCABULARY_SUCCESS,
        vocabulary: data
    };
}

export function errorReceive(err) {
    return {
        type: GET_VOCABULARY_ERROR,
        error: err
    };
}

export function getVocabulary() {
    return (dispatch) => {
        fetch(constants.getVocabulary)
            .then((response) => {
                return response.json();
            }).then((data) => {
                dispatch(receiveVocabulary(data));
            }).catch((ex) => {
                dispatch(errorReceive(ex));
            });
    };
}